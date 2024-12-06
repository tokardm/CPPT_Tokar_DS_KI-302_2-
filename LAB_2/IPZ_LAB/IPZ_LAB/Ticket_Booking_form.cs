using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IPZ_LAB
{
    public partial class Ticket_Booking_form : Form
    {
        private Socket senderSocket;
        private String selectedFilm;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        private String loggedUserID;
        private int row;
        private int seat;
        List<List<Button>> rows;
        private int selectedFilmID;
        public Ticket_Booking_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList, String selectedFilm, String loggedUserID, int selectedFilmID)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList =  buyingList;
            this.selectedFilm = selectedFilm;
            this.loggedUserID = loggedUserID;
            this.selectedFilmID = selectedFilmID;
        
            InitializeComponent();

            Buy_button.Enabled = false;
            Reserve_button.Enabled = false;

            List<Button> seats1 = new List<Button>();
            List<Button> seats2 = new List<Button>();
            List<Button> seats3 = new List<Button>();
            rows = new List<List<Button>>();
            rows.Add(seats1);
            rows.Add(seats2);
            rows.Add(seats3);
            rows[2].Add(s3_4);
            rows[2].Add(s3_3);
            rows[2].Add(s3_2);
            rows[2].Add(s3_1);

            rows[1].Add(s2_4);
            rows[1].Add(s2_3);
            rows[1].Add(s2_2);
            rows[1].Add(s2_1);

            rows[0].Add(s1_4);
            rows[0].Add(s1_3);
            rows[0].Add(s1_2);
            rows[0].Add(s1_1);

            rows[0].Reverse();
            rows[1].Reverse();
            rows[2].Reverse();

            IPZ_LAB.Program.sendData(senderSocket, $"select Film.Film_ID from Film where (CONCAT(Film_Name,'-', [Type])) = '{selectedFilm}'", DateTime.Now);
            String filmId = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);
            String v1 ;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    IPZ_LAB.Program.sendData(senderSocket, $"select count(*) from Booking_{filmId} where row_ID = {i + 1} and seat{j + 1} = 0", DateTime.Now);
                    v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

                    if (v1 == "pass")
                    {
                        rows[i][j].BackColor = Color.Green;
                        rows[i][j].Text = (j+1).ToString();
                    }
                    else
                    {
                        rows[i][j].BackColor = Color.Red;
                        rows[i][j].Text = (j+1).ToString();
                        rows[i][j].Enabled = false;
                    }
                }
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(senderSocket, bookingList, buyingList, loggedUserID);
            form1.Show();
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Reserve_button_Click(object sender, EventArgs e)
        {
            IPZ_LAB.Program.sendData(senderSocket,
                           $"insert into Orders (Order_ID, User_ID, Film_Name, Row, Place, Payment_Card, Reserved) values (((select max(Order_ID) from Orders) + 1), {loggedUserID}, '{selectedFilm}', {row}, {seat},'NULL',1)", DateTime.Now);
            String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

            if (v1 == "pass")
            {
                IPZ_LAB.Program.sendData(senderSocket,
                    $"update Booking_{selectedFilmID} set seat{seat} = 1 where row_ID = {row}; ", DateTime.Now);
                String v2 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);
                MessageBox.Show("Ви успішно забронювали квиток!");
            }
            this.Hide();
            Form1 form1 = new Form1(senderSocket, bookingList, buyingList, loggedUserID);
            form1.Show();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buying_form buying_form = new Buying_form(senderSocket, bookingList, buyingList, loggedUserID, row, seat, false, selectedFilm, selectedFilmID);
            buying_form.Show();
        }
        

        private void s1_1_Click(object sender, EventArgs e)
        {
            row = 1;
            seat = 1;
            resetButtons();
        }
        private void resetButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rows[i][j].BackColor != Color.Red)
                    {
                        rows[i][j].BackColor = Color.Green;
                    }
                }
            }
            rows[row - 1][seat - 1].BackColor = Color.Blue;
            Buy_button.Enabled = true;
            Reserve_button.Enabled = true;
        }

        private void s1_2_Click(object sender, EventArgs e)
        {
            row = 1;
            seat = 2;
            resetButtons();
        }

        private void s1_3_Click(object sender, EventArgs e)
        {
            row = 1;
            seat = 3;
            resetButtons();
        }

        private void s1_4_Click(object sender, EventArgs e)
        {
            row = 1;
            seat = 4;
            resetButtons();
        }

        private void s2_1_Click(object sender, EventArgs e)
        {
            row = 2;
            seat = 1;
            resetButtons();
        }

        private void s2_2_Click(object sender, EventArgs e)
        {
            row = 2;
            seat = 2;
            resetButtons();
        }

        private void s2_3_Click(object sender, EventArgs e)
        {
            row = 2;
            seat = 3;
            resetButtons();
        }

        private void s2_4_Click(object sender, EventArgs e)
        {
            row = 2;
            seat = 4;
            resetButtons();
        }

        private void s3_1_Click(object sender, EventArgs e)
        {
            row = 3;
            seat = 1;
            resetButtons();
        }

        private void s3_2_Click(object sender, EventArgs e)
        {
            row = 3;
            seat = 2;
            resetButtons();
        }

        private void s3_4_Click(object sender, EventArgs e)
        {
            row = 3;
            seat = 4;
            resetButtons();
        }

        private void s3_3_Click(object sender, EventArgs e)
        {
            row = 3;
            seat = 3;
            resetButtons();
        }
    }
}
