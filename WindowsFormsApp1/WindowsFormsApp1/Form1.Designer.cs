namespace WindowsFormsApp1
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_db = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(62, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 29);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(62, 128);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(74, 29);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email";
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_db.Location = new System.Drawing.Point(62, 208);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(115, 29);
            this.lbl_db.TabIndex = 2;
            this.lbl_db.Text = "Birth date";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.Location = new System.Drawing.Point(220, 135);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(177, 22);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "                     @gmail.com";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.Location = new System.Drawing.Point(220, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 4;
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.Location = new System.Drawing.Point(67, 335);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(142, 39);
            this.btn_reg.TabIndex = 5;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Registration form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

