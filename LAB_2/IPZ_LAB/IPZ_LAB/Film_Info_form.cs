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
    public partial class Film_Info_form : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        private String loggedUserID;
        public Film_Info_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList, String loggedUserID)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            this.loggedUserID = loggedUserID;
            InitializeComponent();

            this.Hide();

            IPZ_LAB.Program.sendData(senderSocket,
               $"select * from Film_Info", DateTime.Now);
            String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

            DataSet obj = JsonConvert.DeserializeObject<DataSet>(v1);

            dataGridForm grid = new dataGridForm(obj, senderSocket, bookingList, buyingList, loggedUserID);
            grid.Show();
            //dg.DataSource = obj.Tables[0];
            //dg.Visible = true;
            //dg.BringToFront();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
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
    }
}
