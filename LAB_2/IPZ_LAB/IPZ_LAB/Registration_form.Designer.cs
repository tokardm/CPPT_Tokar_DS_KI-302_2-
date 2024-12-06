namespace IPZ_LAB
{
    partial class Registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Repeat_Password_Box = new System.Windows.Forms.TextBox();
            this.Hide_button = new System.Windows.Forms.Button();
            this.LN_Box = new System.Windows.Forms.TextBox();
            this.FN_Box = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(701, 0);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(99, 30);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Registration_Button
            // 
            this.Registration_Button.BackColor = System.Drawing.Color.White;
            this.Registration_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Registration_Button.FlatAppearance.BorderSize = 0;
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Location = new System.Drawing.Point(0, 420);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(800, 30);
            this.Registration_Button.TabIndex = 5;
            this.Registration_Button.Text = "Зареєструватись";
            this.Registration_Button.UseVisualStyleBackColor = false;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Login_Box
            // 
            this.Login_Box.Location = new System.Drawing.Point(277, 130);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(244, 22);
            this.Login_Box.TabIndex = 6;
            this.Login_Box.Enter += new System.EventHandler(this.Login_Box_Enter);
            this.Login_Box.Leave += new System.EventHandler(this.Login_Box_Leave);
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(278, 158);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(244, 22);
            this.Password_Box.TabIndex = 7;
            this.Password_Box.Enter += new System.EventHandler(this.Password_Box_Enter);
            this.Password_Box.Leave += new System.EventHandler(this.Password_Box_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "РЕЄСТРАЦІЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Repeat_Password_Box
            // 
            this.Repeat_Password_Box.Location = new System.Drawing.Point(278, 186);
            this.Repeat_Password_Box.Name = "Repeat_Password_Box";
            this.Repeat_Password_Box.Size = new System.Drawing.Size(244, 22);
            this.Repeat_Password_Box.TabIndex = 9;
            this.Repeat_Password_Box.Enter += new System.EventHandler(this.Repeat_Password_Box_Enter);
            this.Repeat_Password_Box.Leave += new System.EventHandler(this.Repeat_Password_Box_Leave);
            // 
            // Hide_button
            // 
            this.Hide_button.BackColor = System.Drawing.Color.White;
            this.Hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_button.Location = new System.Drawing.Point(665, 0);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(30, 30);
            this.Hide_button.TabIndex = 12;
            this.Hide_button.Text = "_";
            this.Hide_button.UseVisualStyleBackColor = false;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // LN_Box
            // 
            this.LN_Box.Location = new System.Drawing.Point(278, 102);
            this.LN_Box.Name = "LN_Box";
            this.LN_Box.Size = new System.Drawing.Size(243, 22);
            this.LN_Box.TabIndex = 13;
            this.LN_Box.Enter += new System.EventHandler(this.LN_Box_Enter);
            this.LN_Box.Leave += new System.EventHandler(this.LN_Box_Leave);
            // 
            // FN_Box
            // 
            this.FN_Box.Location = new System.Drawing.Point(278, 74);
            this.FN_Box.Name = "FN_Box";
            this.FN_Box.Size = new System.Drawing.Size(243, 22);
            this.FN_Box.TabIndex = 14;
            this.FN_Box.Enter += new System.EventHandler(this.FN_Box_Enter);
            this.FN_Box.Leave += new System.EventHandler(this.FN_Box_Leave);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.White;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.ForeColor = System.Drawing.Color.Black;
            this.Back_button.Location = new System.Drawing.Point(0, 419);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(97, 30);
            this.Back_button.TabIndex = 15;
            this.Back_button.Text = "НАЗАД";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IPZ_LAB.Properties.Resources.registration_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.FN_Box);
            this.Controls.Add(this.LN_Box);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.Repeat_Password_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Login_Box);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Repeat_Password_Box;
        private System.Windows.Forms.Button Hide_button;
        private System.Windows.Forms.TextBox LN_Box;
        private System.Windows.Forms.TextBox FN_Box;
        private System.Windows.Forms.Button Back_button;
    }
}