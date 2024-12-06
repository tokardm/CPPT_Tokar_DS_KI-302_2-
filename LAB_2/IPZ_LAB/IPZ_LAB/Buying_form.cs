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
using System.Text.RegularExpressions;

namespace IPZ_LAB
{
    public partial class Buying_form : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        private String loggedUserID;
        public String selectedFilm { get; set; }
        private int Row;
        private int Place;
        private bool reserved;
        private int selectedFilmID;
        public Buying_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList, String loggedUserID, int Row, int Place, bool reserved, string selectedFilm, int selectedFilmID)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            this.loggedUserID = loggedUserID;
            this.Row = Row;
            this.Place = Place;
            this.reserved = reserved;
            this.selectedFilm = selectedFilm;
            this.selectedFilmID = selectedFilmID;
            InitializeComponent();
            Payment_Card_Box.Text = "Номер картки";
            Payment_Card_Box.ForeColor = Color.Gray;
            Payment_Card_Box.MaxLength = 16;
            CVV_Box.Text = "CVV";
            CVV_Box.ForeColor = Color.Gray;
            CVV_Box.MaxLength = 3;
            M_Y_Box.Text = "ММ/РР";
            M_Y_Box.ForeColor = Color.Gray;
            M_Y_Box.MaxLength = 5;
        }

        private void Payment_Card_Box_Enter(object sender, EventArgs e)
        {
            if (Payment_Card_Box.Text == "Номер картки")
            {
                Payment_Card_Box.Text = "";
                Payment_Card_Box.ForeColor = Color.Black;
            }
        }

        private void Payment_Card_Box_Leave(object sender, EventArgs e)
        {
            if (Payment_Card_Box.Text == "")
            {
                Payment_Card_Box.Text = "Номер картки";
                Payment_Card_Box.ForeColor = Color.Gray;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_Booking_form ticket_booking_form = new Ticket_Booking_form(senderSocket, bookingList, buyingList, selectedFilm, loggedUserID, selectedFilmID);
            ticket_booking_form.Show();
        }

        private void CVV_Box_Enter(object sender, EventArgs e)
        {
            if (CVV_Box.Text == "CVV")
            {
                CVV_Box.Text = "";
                CVV_Box.ForeColor = Color.Black;
                CVV_Box.UseSystemPasswordChar = true;
            }
        }

        private void CVV_Box_Leave(object sender, EventArgs e)
        {
            if (CVV_Box.Text == "")
            {
                CVV_Box.Text = "CVV";
                CVV_Box.ForeColor = Color.Gray;
                CVV_Box.UseSystemPasswordChar = false;
            }
        }

        private void M_Y_Box_Enter(object sender, EventArgs e)
        {
            if (M_Y_Box.Text == "ММ/РР")
            {
                M_Y_Box.Text = "";
                M_Y_Box.ForeColor = Color.Black;
            }
        }

        private void M_Y_Box_Leave(object sender, EventArgs e)
        {
            if (M_Y_Box.Text == "")
            {
                M_Y_Box.Text = "ММ/РР";
                M_Y_Box.ForeColor = Color.Gray;
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Regex regexDate = new Regex(@"[0-9]{2}/[0-9]{2}$");
            Regex regexCvv = new Regex(@"[0-9]{3}$");
            Regex regexCard = new Regex(@"[0-9]{16}$");

            if (!regexDate.IsMatch(M_Y_Box.Text))
            {
                MessageBox.Show("Заповніть поле ММ/РР правильно!");
                return;
            }
            if (!regexCvv.IsMatch(CVV_Box.Text))
            {
                MessageBox.Show("Заповніть поле CVV правильно!");
                return;
            }
            if (!regexCard.IsMatch(Payment_Card_Box.Text))
            {
                MessageBox.Show("Поле повинне містити 16 цифр!");
                return;
            }
            IPZ_LAB.Program.sendData(senderSocket,
                            $"insert into Orders (Order_ID, User_ID, Film_Name, Row, Place, Payment_Card, Reserved) values (((select max(Order_ID) from Orders) + 1), {loggedUserID}, '{selectedFilm}', {Row}, {Place},'{Payment_Card_Box.Text}',{Convert.ToInt32(reserved)})", DateTime.Now);
            String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

            if (v1 == "pass")
            {
                try
                {
                    IPZ_LAB.Program.sendData(senderSocket,
                        $"update Booking_{selectedFilmID} set seat{Place} = 1 where row_ID = {Row}; ", DateTime.Now);
                    String v2 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);
                    MessageBox.Show("Операція пройшла успішно!");
                }
                catch(Exception e1)
                {
                    MessageBox.Show($"Операція провалена на сервері\nПомилка: {e1.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Операцію не здійснено!");
            }
            this.Hide();
            Form1 form1 = new Form1(senderSocket, bookingList, buyingList, loggedUserID);
            form1.Show();
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
