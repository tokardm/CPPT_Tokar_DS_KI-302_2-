namespace IPZ_LAB
{
    partial class Login_form
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
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Login_Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hide_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Box
            // 
            this.Login_Box.Location = new System.Drawing.Point(258, 216);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(244, 22);
            this.Login_Box.TabIndex = 1;
            this.Login_Box.Enter += new System.EventHandler(this.Login_Box_Enter);
            this.Login_Box.Leave += new System.EventHandler(this.Login_Box_Leave);
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(258, 273);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(244, 22);
            this.Password_Box.TabIndex = 2;
            this.Password_Box.Enter += new System.EventHandler(this.Password_Box_Enter);
            this.Password_Box.Leave += new System.EventHandler(this.Password_Box_Leave);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(662, 0);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(99, 30);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.White;
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Location = new System.Drawing.Point(0, 420);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(760, 30);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Вхід";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Picture
            // 
            this.Login_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Picture.Image = global::IPZ_LAB.Properties.Resources.login_background;
            this.Login_Picture.Location = new System.Drawing.Point(0, 0);
            this.Login_Picture.Name = "Login_Picture";
            this.Login_Picture.Size = new System.Drawing.Size(800, 450);
            this.Login_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_Picture.TabIndex = 0;
            this.Login_Picture.TabStop = false;
            this.Login_Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Picture_MouseDown);
            this.Login_Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_Picture_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "АВТОРИЗАЦІЯ";
            // 
            // Hide_button
            // 
            this.Hide_button.BackColor = System.Drawing.Color.White;
            this.Hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_button.Location = new System.Drawing.Point(626, 0);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(30, 30);
            this.Hide_button.TabIndex = 11;
            this.Hide_button.Text = "_";
            this.Hide_button.UseVisualStyleBackColor = false;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.White;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.ForeColor = System.Drawing.Color.Black;
            this.Back_button.Location = new System.Drawing.Point(0, 420);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(97, 30);
            this.Back_button.TabIndex = 13;
            this.Back_button.Text = "НАЗАД";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Login_Box);
            this.Controls.Add(this.Login_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            ((System.ComponentModel.ISupportInitialize)(this.Login_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Picture;
        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hide_button;
        private System.Windows.Forms.Button Back_button;
    }
}