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
using Newtonsoft.Json;

namespace IPZ_LAB
{
    public partial class Form1 : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        private String loggedUserID;
        public Form1(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList,String loggedUserID)
        {
            this.senderSocket = senderSocket;
            this.loggedUserID = loggedUserID;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_film_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film_Search_form film_search_form = new Film_Search_form(senderSocket, bookingList, buyingList, loggedUserID);
            film_search_form.Show();
        }

        private void Timetable_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetable_form timetable_form = new Timetable_form(senderSocket, bookingList, buyingList, loggedUserID);
            timetable_form.Show();
        }

        private void Film_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            IPZ_LAB.Program.sendData(senderSocket,
               $"select * from Film_Info", DateTime.Now);
            String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

            DataSet obj = JsonConvert.DeserializeObject<DataSet>(v1);

            dataGridForm grid = new dataGridForm(obj, senderSocket, bookingList, buyingList, loggedUserID);
            grid.Show();
            //Film_Info_form film_info_form = new Film_Info_form(senderSocket, bookingList, buyingList);
            //film_info_form.Show();
        }

        private void Reserve_button_Click(object sender, EventArgs e)
        {
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void main_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void main_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
