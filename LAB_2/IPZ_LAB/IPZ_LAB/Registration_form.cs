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
    public partial class Registration_form : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        public Registration_form(Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList)
        {
            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            InitializeComponent();
            Login_Box.Text = "Введіть емейл";
            Login_Box.ForeColor = Color.Gray;
            Password_Box.Text = "Введіть пароль";
            Password_Box.ForeColor = Color.Gray;
            Repeat_Password_Box.Text = "Повторіть пароль";
            Repeat_Password_Box.ForeColor = Color.Gray;
            FN_Box.Text = "Введіть ім'я";
            FN_Box.ForeColor = Color.Gray;
            LN_Box.Text = "Введіть прізвище";
            LN_Box.ForeColor = Color.Gray;
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

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 form1 = new Form1(senderSocket);
            //form1.Show();
            bool dataExists = false;
            if (Password_Box.Text == Repeat_Password_Box.Text)
            {
                IPZ_LAB.Program.sendData(senderSocket, $"select count(*) from User_INFO where Email like '{this.Login_Box.Text}'", DateTime.Now);
                String v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

                if (v1 == "pass")
                {
                    dataExists = true;
                }

                 
                if (!dataExists)
                {
                    IPZ_LAB.Program.sendData(senderSocket,
                        $"insert into User_INFO (User_ID, First_Name, Last_Name, Email, Pass) values (((select max(User_ID) from User_INFO) + 1), '{FN_Box.Text}', '{LN_Box.Text}', '{Login_Box.Text}', '{Password_Box.Text}')", DateTime.Now);
                    v1 = IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now);

                    if (v1 == "pass")
                    {
                        MessageBox.Show("Реєстрація пройшла успішно!");
                        this.Hide();
                        Form1 lmf = new Form1(senderSocket, bookingList, buyingList, IPZ_LAB.Program.receiveData(senderSocket, DateTime.Now));
                        lmf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Такий емейл вже існує!");
                }
            }
            else
            {
                MessageBox.Show("Паролі не збігаються!");
            }
           
        }

        private void Repeat_Password_Box_Enter(object sender, EventArgs e)
        {
            if (Repeat_Password_Box.Text == "Повторіть пароль")
            {
                Repeat_Password_Box.Text = "";
                Repeat_Password_Box.ForeColor = Color.Black;
                Repeat_Password_Box.UseSystemPasswordChar = true;
            }
        }

        private void Repeat_Password_Box_Leave(object sender, EventArgs e)
        {
            if (Repeat_Password_Box.Text == "")
            {
                Repeat_Password_Box.Text = "Повторіть пароль";
                Repeat_Password_Box.ForeColor = Color.Gray;
                Repeat_Password_Box.UseSystemPasswordChar = false;
            }
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

        private void FN_Box_Enter(object sender, EventArgs e)
        {
            if (FN_Box.Text == "Введіть ім'я")
            {
                FN_Box.Text = "";
                FN_Box.ForeColor = Color.Black;
            }
        }

        private void FN_Box_Leave(object sender, EventArgs e)
        {
            if (FN_Box.Text == "")
            {
                FN_Box.Text = "Введіть ім'я";
                FN_Box.ForeColor = Color.Gray;
            }
        }

        private void LN_Box_Enter(object sender, EventArgs e)
        {
            if (LN_Box.Text == "Введіть прізвище")
            {
                LN_Box.Text = "";
                LN_Box.ForeColor = Color.Black;
            }
        }

        private void LN_Box_Leave(object sender, EventArgs e)
        {
            if (LN_Box.Text == "")
            {
                LN_Box.Text = "Введіть прізвище";
                LN_Box.ForeColor = Color.Gray;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Window_form start_window_form = new Start_Window_form(senderSocket, bookingList, buyingList);
            start_window_form.Show();
        }

    }  
}
