namespace IPZ_LAB
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hide_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Film_info_button = new System.Windows.Forms.Button();
            this.Timetable_button = new System.Windows.Forms.Button();
            this.Search_film_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.main_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hide_button);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Film_info_button);
            this.panel1.Controls.Add(this.Timetable_button);
            this.panel1.Controls.Add(this.Search_film_button);
            this.panel1.Controls.Add(this.Cancel_button);
            this.panel1.Controls.Add(this.main_pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Hide_button
            // 
            this.Hide_button.BackColor = System.Drawing.Color.White;
            this.Hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_button.Location = new System.Drawing.Point(621, 0);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(30, 30);
            this.Hide_button.TabIndex = 11;
            this.Hide_button.Text = "_";
            this.Hide_button.UseVisualStyleBackColor = false;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.PeachPuff;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(205, 402);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(345, 37);
            this.Exit_button.TabIndex = 7;
            this.Exit_button.Text = "ВИХІД";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "ГОЛОВНЕ МЕНЮ";
            // 
            // Film_info_button
            // 
            this.Film_info_button.BackColor = System.Drawing.Color.Coral;
            this.Film_info_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Film_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Film_info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Film_info_button.Location = new System.Drawing.Point(205, 274);
            this.Film_info_button.Name = "Film_info_button";
            this.Film_info_button.Size = new System.Drawing.Size(345, 38);
            this.Film_info_button.TabIndex = 4;
            this.Film_info_button.Text = "Інформація про фільми";
            this.Film_info_button.UseVisualStyleBackColor = false;
            this.Film_info_button.Click += new System.EventHandler(this.Film_info_button_Click);
            // 
            // Timetable_button
            // 
            this.Timetable_button.BackColor = System.Drawing.Color.Plum;
            this.Timetable_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timetable_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timetable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timetable_button.Location = new System.Drawing.Point(205, 337);
            this.Timetable_button.Name = "Timetable_button";
            this.Timetable_button.Size = new System.Drawing.Size(345, 37);
            this.Timetable_button.TabIndex = 3;
            this.Timetable_button.Text = "Розклад фільмів";
            this.Timetable_button.UseVisualStyleBackColor = false;
            this.Timetable_button.Click += new System.EventHandler(this.Timetable_button_Click);
            // 
            // Search_film_button
            // 
            this.Search_film_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.Search_film_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_film_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_film_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_film_button.Location = new System.Drawing.Point(205, 215);
            this.Search_film_button.Name = "Search_film_button";
            this.Search_film_button.Size = new System.Drawing.Size(345, 39);
            this.Search_film_button.TabIndex = 2;
            this.Search_film_button.Text = "Пошук фільмів за жанром";
            this.Search_film_button.UseVisualStyleBackColor = false;
            this.Search_film_button.Click += new System.EventHandler(this.Search_film_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(657, 0);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(99, 30);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // main_pictureBox
            // 
            this.main_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_pictureBox.Image = global::IPZ_LAB.Properties.Resources.main_background;
            this.main_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.main_pictureBox.Name = "main_pictureBox";
            this.main_pictureBox.Size = new System.Drawing.Size(756, 451);
            this.main_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_pictureBox.TabIndex = 0;
            this.main_pictureBox.TabStop = false;
            this.main_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_pictureBox_MouseDown);
            this.main_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_pictureBox_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.PictureBox main_pictureBox;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Film_info_button;
        private System.Windows.Forms.Button Timetable_button;
        private System.Windows.Forms.Button Search_film_button;
        private System.Windows.Forms.Button Hide_button;
    }
}

