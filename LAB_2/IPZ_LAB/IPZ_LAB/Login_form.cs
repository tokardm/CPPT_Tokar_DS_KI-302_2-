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
    public partial class Login_form : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        public Login_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            InitializeComponent();
            Login_Box.Text = "Введіть емейл";
            Login_Box.ForeColor = Color.Gray;
            Password_Box.Text = "Введіть пароль";
            Password_Box.ForeColor = Color.Gray;
        }

        private void Login_Box_Enter(object sender, EventArgs e)
        {
            if (Login_Box.Text == "Введіть емейл")
            {
                Login_Box.Text = "";
                Login_Box.ForeColor = Color.Black;
            }
        }

        private void Login_Box_Leave(object sender, EventArgs e)
        {
            if (Login_Box.Text == "")
            {
                Login_Box.Text = "Введіть емейл";
                Login_Box.ForeColor = Color.Gray;
            }

        }

        private void Password_Box_Enter(object sender, EventArgs e)
        {
            if (Password_Box.Text == "Введіть пароль")
            {
                Password_Box.Text = "";
                Password_Box.ForeColor = Color.Black;
                Password_Box.UseSystemPasswordChar = true;
            }
        }

        private void Password_Box_Leave(object sender, EventArgs e)
        {
            if (Password_Box.Text == "")
            {
                Password_Box.Text = "Введіть пароль";
                Password_Box.ForeColor = Color.Gray;
                Password_Box.UseSystemPasswordChar = false;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // Form1 form1 = new Form1();
            // form1.Show();
            bool passVerification = false;

            IPZ_LAB.Program.sendData(senderSocket, $"select count(*) from User_INFO where Email like '{this.Login_Box.Text}' and Pass like '{this.Password_Box.Text}'", DateTime.Now);
            String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);
            
            if (v1.Contains("pass"))
            {
                passVerification = true;
            }
            else if (v1.Contains("close"))
            {
                Application.Restart();
            }

            if (passVerification)
            {
                this.Hide();
                Form1 lmf = new Form1(senderSocket, bookingList, buyingList, IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now));
                lmf.Show();
            }
            else
            {
                MessageBox.Show("Неправильні облікові дані!");
            }
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void Login_Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_Picture_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Window_form start_window_form = new Start_Window_form(senderSocket, bookingList, buyingList);
            start_window_form.Show();
        }
    }
}
