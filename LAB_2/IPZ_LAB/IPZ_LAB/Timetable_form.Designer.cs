namespace IPZ_LAB
{
    partial class Timetable_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Hide_button = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Розклад фільмів";
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
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.White;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.ForeColor = System.Drawing.Color.Black;
            this.Back_button.Location = new System.Drawing.Point(0, 407);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(146, 43);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "НАЗАД";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
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
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 81);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(776, 272);
            this.dg.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Iron Man-2D",
            "Iron Man-3D",
            "Green Mile-2D",
            "Sherlock Holmes-3D",
            "Beauty and the Beast-IMAX",
            "Greenland-3D",
            "Greenland-IMAX",
            "The Hangover-3D",
            "The Maze Runner-3D",
            "Tomb Raider: Lara Croft-IMAX",
            "Tomb Raider: Lara Croft-2D",
            "We are the Millers-2D",
            "We are the Millers-3D",
            "A Star Is Born-3D"});
            this.comboBox1.Location = new System.Drawing.Point(343, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IPZ_LAB.Properties.Resources.timetable_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Timetable_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timetable_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable_form";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Hide_button;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}