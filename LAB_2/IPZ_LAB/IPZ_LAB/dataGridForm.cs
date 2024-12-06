using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace IPZ_LAB
{
    public partial class dataGridForm : Form
    {
        private Socket senderSocket;
        private List<Booking> bookingList;
        private List<Buying> buyingList;
        private String loggedUserID;
        public dataGridForm(DataSet ds, Socket senderSocket, List<Booking> bookingList, List<Buying> buyingList, string loggedUserID)
        {
            InitializeComponent();

            this.senderSocket = senderSocket;
            this.bookingList = bookingList;
            this.buyingList = buyingList;
            this.dg.DataSource = ds.Tables[0];
            this.loggedUserID = loggedUserID;
            if (dg.NewRowIndex == -1)
            {
                MessageBox.Show("Нічого не знайдено!");
                return;
            }
            else
            {
                this.Show();
                dg.Visible = true;
                dg.BringToFront();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(senderSocket, bookingList, buyingList, loggedUserID);
            form1.Show();
        }
    }
}
