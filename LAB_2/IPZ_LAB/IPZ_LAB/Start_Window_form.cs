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
    public partial class Start_Window_form : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        public Start_Window_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login_form = new Login_form(senderSocket, bookingList, buyingList);
            login_form.Show();
        }

        private void regist_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_form registration_form = new Registration_form(senderSocket, bookingList, buyingList);
            registration_form.Show();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
