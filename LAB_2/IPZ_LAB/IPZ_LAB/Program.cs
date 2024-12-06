using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net.Mail;
using System.Data.SqlClient;


namespace IPZ_LAB
{
    
    public class Booking
    {
        public String Film_Name;
        public String Type;
        public int row;
        public int place;

        public bool compare(Booking compared)
        {
            if (this.Film_Name == compared.Film_Name && this.Type == compared.Type && this.row == compared.row &&
                this.place == compared.place)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Buying
    {
        public String Film_Name;
        public String Type;
        public int row;
        public int place;

        public bool compare(Buying compared)
        {
            if (this.Film_Name == compared.Film_Name && this.Type == compared.Type && this.row == compared.row &&
                this.place == compared.place)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static class Program
    { 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false); 
            //Application.Run(new Start_Window_form());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DateTime now = DateTime.Now;
            if (!Directory.Exists("log"))
            {
                Directory.CreateDirectory("log");
            }
            Socket sender = null;
            DialogResult dr2 = DialogResult.Retry;

            while (dr2 == DialogResult.Retry)
            {
                sender = StartClient2(sender, now);
                if (sender != null)
                {
                    Application.Run(new Start_Window_form(sender, new List<Booking>() , new List<Buying>()));
                    IPZ_LAB.Program.sendData(sender, "closed", now);
                }
                
                sender.Shutdown(SocketShutdown.Both);
                sender.Shutdown(SocketShutdown.Send);
                sender.Close();

                DialogResult dr = MessageBox.Show("Спробувати знову ?", "Підключення втрачено", MessageBoxButtons.RetryCancel);

                if (dr == DialogResult.Cancel)
                {
                    dr2 = DialogResult.Cancel;
                }
            }
            Application.Exit();
        }
        public static Socket StartClient2(Socket sender, DateTime now)
        {
            while (sender == null)
            {
                //Socket sender = StartClient(now, args[0].ToString(), args[1].ToString());

                sender = StartClient(now, "192.168.199.156", "27000");

                if (sender != null)
                {
                    return sender;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Спробувати знову ?", "Сервер не знайдено", MessageBoxButtons.RetryCancel);

                    writeToFile(now, "Server didn't start");

                    if (dr != DialogResult.Retry)
                        return null;
                }
            }
            return sender;
        }

        public static void writeToFile(DateTime time, String str)
        {
            DateTime currentTime = DateTime.Now;
            using (StreamWriter sw = File.AppendText($"log\\{time.Day}_{time.Month}_{time.Year}--{time.Hour}_{time.Minute}_{time.Second}.log"))
            {
                sw.WriteLine($"{currentTime} : {str} ");
            }
        }
        public static void sendData(Socket sender, String str, DateTime now)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes($"{str}<EOF>");
                sender.Send(msg);
                writeToFile(now, $"Sent: {str}");
            }
            catch (Exception e)
            {
                writeToFile(now, $"Error sending data: {e.Message}");
                MessageBox.Show($"Error sending data: {e.Message}");
            }
        }

        public static String receiveData(Socket sender, DateTime now)
        {
            try
            {
                byte[] bytes = new byte[16384];
                int bytesRec = sender.Receive(bytes);
                String receivedMessage = $"{Encoding.ASCII.GetString(bytes, 0, bytesRec)}";
                writeToFile(now, $"Received: {receivedMessage}");
                return receivedMessage;
            }
            catch (Exception e)
            {
                writeToFile(now, $"Error receiving data: {e.Message}");
                MessageBox.Show($"Error receiving data: {e.Message}");
                return "close";
            }
        }

        public static Socket StartClient(DateTime now, String ip, String Port)
        {
            byte[] bytes = new byte[1024];
            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sender.Connect(IPAddress.Parse(ip), Convert.ToInt32(Port));
                writeToFile(now, $"Socket connected to {sender.RemoteEndPoint.ToString()}");
            }
            catch (Exception e)
            {
                writeToFile(now, $"Error in StartClient: {e.Message}");
                return null;
            }

            return sender;
        }


    }
}
