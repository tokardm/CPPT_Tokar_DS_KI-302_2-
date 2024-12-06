namespace IPZ_LAB
{
    partial class Start_Window_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regist_button = new System.Windows.Forms.Button();
            this.Entrance_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Hide_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IPZ_LAB.Properties.Resources.start_window_backgroung;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // regist_button
            // 
            this.regist_button.BackColor = System.Drawing.Color.Black;
            this.regist_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regist_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.regist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regist_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regist_button.ForeColor = System.Drawing.Color.Silver;
            this.regist_button.Location = new System.Drawing.Point(0, 508);
            this.regist_button.Name = "regist_button";
            this.regist_button.Size = new System.Drawing.Size(412, 44);
            this.regist_button.TabIndex = 1;
            this.regist_button.Text = "ЗАРЕЄСТРУВАТИСЬ";
            this.regist_button.UseVisualStyleBackColor = false;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // Entrance_button
            // 
            this.Entrance_button.BackColor = System.Drawing.Color.Black;
            this.Entrance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrance_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Entrance_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrance_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Entrance_button.ForeColor = System.Drawing.Color.Silver;
            this.Entrance_button.Location = new System.Drawing.Point(0, 461);
            this.Entrance_button.Name = "Entrance_button";
            this.Entrance_button.Size = new System.Drawing.Size(412, 47);
            this.Entrance_button.TabIndex = 2;
            this.Entrance_button.Text = "ВВІЙТИ";
            this.Entrance_button.UseVisualStyleBackColor = false;
            this.Entrance_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вітаємо у CINEMA CITY ";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(313, 0);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(99, 30);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Hide_button
            // 
            this.Hide_button.BackColor = System.Drawing.Color.White;
            this.Hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_button.Location = new System.Drawing.Point(277, 0);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(30, 30);
            this.Hide_button.TabIndex = 10;
            this.Hide_button.Text = "_";
            this.Hide_button.UseVisualStyleBackColor = false;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Start_Window_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 552);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrance_button);
            this.Controls.Add(this.regist_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start_Window_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Window_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button regist_button;
        private System.Windows.Forms.Button Entrance_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Hide_button;
    }
}