namespace IPZ_LAB
{
    partial class Buying_form
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
            System.Windows.Forms.Label row;
            this.Back_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Payment_Card_Box = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Hide_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.CVV_Box = new System.Windows.Forms.TextBox();
            this.M_Y_Box = new System.Windows.Forms.TextBox();
            row = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // row
            // 
            row.AutoSize = true;
            row.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            row.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            row.ForeColor = System.Drawing.Color.Snow;
            row.Location = new System.Drawing.Point(12, 33);
            row.Name = "row";
            row.Size = new System.Drawing.Size(230, 30);
            row.TabIndex = 18;
            row.Text = "Введіть ваші дані:";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.ForeColor = System.Drawing.Color.White;
            this.Back_button.Location = new System.Drawing.Point(1, 407);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(146, 43);
            this.Back_button.TabIndex = 6;
            this.Back_button.Text = "НАЗАД";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(144, 407);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(142, 43);
            this.Exit_button.TabIndex = 7;
            this.Exit_button.Text = "ВИХІД";
            this.Exit_button.UseVisualStyleBackColor = false;
            // 
            // Payment_Card_Box
            // 
            this.Payment_Card_Box.Location = new System.Drawing.Point(12, 75);
            this.Payment_Card_Box.Name = "Payment_Card_Box";
            this.Payment_Card_Box.Size = new System.Drawing.Size(288, 22);
            this.Payment_Card_Box.TabIndex = 17;
            this.Payment_Card_Box.Enter += new System.EventHandler(this.Payment_Card_Box_Enter);
            this.Payment_Card_Box.Leave += new System.EventHandler(this.Payment_Card_Box_Leave);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(700, 0);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(99, 30);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Закрити\r\n";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Hide_button
            // 
            this.Hide_button.BackColor = System.Drawing.Color.White;
            this.Hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide_button.Location = new System.Drawing.Point(664, 0);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(30, 30);
            this.Hide_button.TabIndex = 20;
            this.Hide_button.Text = "_";
            this.Hide_button.UseVisualStyleBackColor = false;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.White;
            this.Next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Next_button.Location = new System.Drawing.Point(12, 197);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(46, 32);
            this.Next_button.TabIndex = 21;
            this.Next_button.Text = ">>";
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // CVV_Box
            // 
            this.CVV_Box.Location = new System.Drawing.Point(12, 150);
            this.CVV_Box.Name = "CVV_Box";
            this.CVV_Box.Size = new System.Drawing.Size(92, 22);
            this.CVV_Box.TabIndex = 22;
            this.CVV_Box.Enter += new System.EventHandler(this.CVV_Box_Enter);
            this.CVV_Box.Leave += new System.EventHandler(this.CVV_Box_Leave);
            // 
            // M_Y_Box
            // 
            this.M_Y_Box.Location = new System.Drawing.Point(12, 113);
            this.M_Y_Box.Name = "M_Y_Box";
            this.M_Y_Box.Size = new System.Drawing.Size(92, 22);
            this.M_Y_Box.TabIndex = 23;
            this.M_Y_Box.Enter += new System.EventHandler(this.M_Y_Box_Enter);
            this.M_Y_Box.Leave += new System.EventHandler(this.M_Y_Box_Leave);
            // 
            // Buying_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IPZ_LAB.Properties.Resources.u;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.M_Y_Box);
            this.Controls.Add(this.CVV_Box);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(row);
            this.Controls.Add(this.Payment_Card_Box);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buying_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_Buying_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TextBox Payment_Card_Box;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Hide_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.TextBox CVV_Box;
        private System.Windows.Forms.TextBox M_Y_Box;
    }
}