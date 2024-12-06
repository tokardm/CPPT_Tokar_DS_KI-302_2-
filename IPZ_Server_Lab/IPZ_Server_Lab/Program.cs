using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;

namespace IPZ_Server_Lab
{
    class Film_Info
    {
        public String Film_Name { get; set; }
        public String Rating { get; set; }
        public String Producing_Country { get; set; }
        public String Budget { get; set; }
        public Film_Info()
        {
            this.Film_Name = "";
            this.Rating = "";
            this.Producing_Country = "";
            this.Budget = "";
        }
    }
    class Film_Information
    {
        public List<Film_Info> film_info_List { get; set; }
        public Film_Information()
        {
            film_info_List = new List<Film_Info>();
        }
    }
    class Film
    {
        public String Film_Name { get; set; }
        public String Type { get; set; }
        public String Genre { get; set; }
        public String Price { get; set; }
        public String Time { get; set; }
        public Film()
        {
            this.Film_Name = "";
            this.Type = "";
            this.Genre = "";
            this.Price = "";
            this.Time = "";
         
        }
    }
    class TimeTable
    {
        public List<Film> filmList { get; set; }
        public TimeTable()
        {
            filmList = new List<Film>();
        }
    }
    class Program
    {
        public static void writeToFile(DateTime time, String str)
        {
            DateTime currentTime = DateTime.Now;
            using (StreamWriter sw = File.AppendText($"log\\{time.Day}_{time.Month}_{time.Year}--{time.Hour}_{time.Minute}_{time.Second}.log"))
            {
                sw.WriteLine($"{currentTime} : {str} ");
            }
        }
        public static string receiveData(Socket handler, DateTime now)
        {
            string data = null;
            byte[] bytes = null;

            while (true)
            {
                bytes = new byte[16384];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }

            writeToFile(now, $"Received: {data}");
            return data;
        }
        public static void sendData(Socket handler, string data, DateTime now)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data);
            handler.Send(msg);          
            writeToFile(now, $"Sent: {data}");
        }
        static void Main(string[] args)
        {
            if (!Directory.Exists("log"))
            {
                Directory.CreateDirectory("log");
            }
        label:
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Parse ("192.168.199.156"), 27000));
            listener.Listen(10);

            DateTime now = DateTime.Now;

            SqlConnection _sql;
            string connectionString = "Server=DESKTOP-U2VKM2D\\MSSQLSERVER01; Database=aa;Integrated Security = SSPI;";

            _sql = new SqlConnection(connectionString);


            try
            {
                //writeToFile(now, "Waiting for connection.");
                Console.WriteLine("Waiting for a connection.");
                Socket handler = listener.Accept();

                writeToFile(now, $"Connected to {handler.RemoteEndPoint.ToString()}");
                _sql.Open();

                while (true)
                {
                    String rec = receiveData(handler, now);
                    rec = rec.Remove(rec.Length - 5);
                    Console.WriteLine(rec);
                    if (rec == "closed")
                    {
                        sendData(handler, "Closing connection", now);
                        handler.Shutdown(SocketShutdown.Both); // Properly shutting down the connection
                        handler.Close(); // Close the connection
                        listener.Close();
                        goto label;
                    }



                    if (rec.Contains("count(*)"))
                    {
                        SqlCommand sqlCommand = new SqlCommand(rec, _sql);
                        int count = (int)sqlCommand.ExecuteScalar();

                        if (count == 1)
                        {
                            sendData(handler, "pass", now);
                            Console.WriteLine("pass");

                            if (!rec.Contains("Booking"))
                            {
                                SqlDataReader dataReader;
                                String Output = "";

                                SqlCommand command = new SqlCommand(rec.Replace("count(*)", "User_ID"), _sql);
                                dataReader = command.ExecuteReader();

                                while (dataReader.Read())
                                {
                                    Output = dataReader.GetValue(0).ToString();
                                }
                                dataReader.Close();
                                sendData(handler, Output, now);
                                Console.WriteLine(Output);
                            }
                        }
                        else
                        {
                            sendData(handler, "fail", now);
                            Console.WriteLine("fail");
                        }
                    }
                    else if (rec.Contains("update"))
                    {
                        SqlCommand command;
                        String sql;
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        command = new SqlCommand(rec, _sql);

                        adapter.UpdateCommand = new SqlCommand(rec, _sql);
                        try
                        {
                            adapter.UpdateCommand.ExecuteNonQuery();
                            sendData(handler, "pass", now);
                            Console.WriteLine("pass");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Wrong command - {0}", rec);
                            sendData(handler, "fail", now);
                            Console.WriteLine("fail");
                        }

                        command.Dispose();
                    }
                    else if (rec.Contains("insert"))
                    {
                        SqlCommand command = new SqlCommand(rec, _sql);
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.InsertCommand = new SqlCommand(rec, _sql);
                        try
                        {
                            adapter.InsertCommand.ExecuteNonQuery();
                            sendData(handler, "pass", now);
                            Console.WriteLine("pass");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Wrong command - {0}", rec);
                            sendData(handler, "fail", now);
                        }
                        command.Dispose();
                    }
                    else if (rec == "select * from Film" || rec.Contains("select * from Film where Genre ="))
                    {
                        SqlDataReader dataReader;
                        String Output = "";

                        SqlCommand command = new SqlCommand(rec, _sql);
                        dataReader = command.ExecuteReader();

                        TimeTable timeTable = new TimeTable();
                        Film film = new Film();

                        int x = 0;

                        while (dataReader.Read())
                        {
                            try
                            {
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    if (i == 0)
                                    {
                                        timeTable.filmList.Add(new Film());
                                        x = timeTable.filmList.Count - 1;
                                    }
                                    try
                                    {
                                        if (dataReader.GetName(i) == "Film_Name")
                                        {
                                            timeTable.filmList[x].Film_Name = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Type")
                                        {
                                            timeTable.filmList[x].Type = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Genre")
                                        {
                                            timeTable.filmList[x].Genre = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Price")
                                        {
                                            timeTable.filmList[x].Price = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Time")
                                        {
                                            timeTable.filmList[x].Time = $"{dataReader.GetValue(i)}";
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        break;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //Console.WriteLine("Wrong command - {0}", rec);
                                sendData(handler, "List with all films: failed", now);
                                Console.WriteLine("List with all films: failed");
                                break;
                            }
                        }
                        Output = JsonConvert.SerializeObject(timeTable, Formatting.Indented);
                        sendData(handler, Output, now);
                        Console.WriteLine($"List with all films \n{Output}");
                        dataReader.Close();
                        command.Dispose();
                    }
                    else if (rec == "select * from Film_Info")
                    {
                        SqlDataReader dataReader;
                        String Output = "";

                        SqlCommand command = new SqlCommand(rec, _sql);
                        dataReader = command.ExecuteReader();

                        Film_Information film_information = new Film_Information();
                        Film_Info film_Info = new Film_Info();

                        int x = 0;

                        while (dataReader.Read())
                        {
                            try
                            {
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    if (i == 0)
                                    {
                                        film_information.film_info_List.Add(new Film_Info());
                                        x = film_information.film_info_List.Count - 1;
                                    }
                                    try
                                    {
                                        if (dataReader.GetName(i) == "Film_Name")
                                        {
                                            film_information.film_info_List[x].Film_Name = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Rating")
                                        {
                                            film_information.film_info_List[x].Rating = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Producing_Country")
                                        {
                                            film_information.film_info_List[x].Producing_Country = $"{dataReader.GetValue(i)}";
                                        }
                                        else if (dataReader.GetName(i) == "Budget")
                                        {
                                            film_information.film_info_List[x].Budget = $"{dataReader.GetValue(i)}";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        break;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //Console.WriteLine("Wrong command - {0}", rec);
                                sendData(handler, "List with all film information: failed", now);
                                Console.WriteLine("List with all film information: failed");
                                break;
                            }
                        }


                        Output = JsonConvert.SerializeObject(film_information, Formatting.Indented);
                        sendData(handler, Output, now);
                        Console.WriteLine($"List with all film information returned \n{Output}");
                        dataReader.Close();
                        command.Dispose();
                    }
                    else if (rec.Contains("[Type]"))
                    {
                        SqlDataReader dataReader;
                        String Output = "";

                        SqlCommand command = new SqlCommand(rec, _sql);
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            try
                            {
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {

                                    try
                                    {
                                        Output = $"{dataReader.GetValue(i)}";
                                    }
                                    catch (Exception ex)
                                    {
                                        break;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //Console.WriteLine("Wrong command - {0}", rec);
                                sendData(handler, "List with all film information: failed", now);
                                Console.WriteLine("List with all film information: failed");
                                break;
                            }
                        }

                        sendData(handler, Output, now);
                        Console.WriteLine($"Get film ID returned \n{Output}");
                        dataReader.Close();
                        command.Dispose();
                    }
                }
                //handler.Shutdown(SocketShutdown.Both);
                //handler.Disconnect(true);
                handler.Dispose();
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //listener.Shutdown(SocketShutdown.Both);
            //listener.Disconnect(true);

            listener.Dispose();

            //Console.WriteLine("Press any key to continue close server .exe");
            //Console.ReadKey();
            _sql.Close();
        }
        static string createQueryUserByParam(string tableName, string paramName = "", string paramValue = "", string paramNames = "*")
        {
            if (paramName == "" || paramValue == "" || paramNames == "")
                return $"SELECT {paramNames} FROM {tableName}";
            else
                return $"SELECT {paramNames} FROM {tableName} WHERE {paramName} = '{paramValue}'";
        }
        static String ShowData(SqlConnection _sql, string query, bool onlyID = false)
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String Output = "";

            command = new SqlCommand(query, _sql);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                try
                {
                    for (int i = (onlyID ? 2 : 0); i < (onlyID ? 3 : dataReader.FieldCount); i++)
                    {
                        try
                        {
                            Output += $"{dataReader.GetName(i)}: {dataReader.GetValue(i)}\n";
                        }
                        catch (Exception ex)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong command - {0}", query);
                    break;
                }
            }

            dataReader.Close();
            command.Dispose();

            return Output;
        }
    }
}
