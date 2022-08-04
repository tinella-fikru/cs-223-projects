namespace WindowsformAppWithLogin
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
            this.components = new System.ComponentModel.Container();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ph = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_chk = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(55, 475);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 32);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(352, 475);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 32);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(65, 69);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(33, 22);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(65, 157);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 22);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "NAME";
            // 
            // lbl_ph
            // 
            this.lbl_ph.AutoSize = true;
            this.lbl_ph.Location = new System.Drawing.Point(51, 238);
            this.lbl_ph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ph.Name = "lbl_ph";
            this.lbl_ph.Size = new System.Drawing.Size(108, 22);
            this.lbl_ph.TabIndex = 4;
            this.lbl_ph.Text = "PHONE No";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(304, 74);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(136, 29);
            this.txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(304, 157);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(136, 29);
            this.txt_name.TabIndex = 6;
            // 
            // txt_ph
            // 
            this.txt_ph.Location = new System.Drawing.Point(304, 238);
            this.txt_ph.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(136, 29);
            this.txt_ph.TabIndex = 7;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(55, 379);
            this.rdb_male.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(90, 26);
            this.rdb_male.TabIndex = 8;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "MALE";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(352, 379);
            this.rdb_female.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(116, 26);
            this.rdb_female.TabIndex = 9;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "FEMALE";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Location = new System.Drawing.Point(571, 69);
            this.chkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(170, 26);
            this.chkBox1.TabIndex = 10;
            this.chkBox1.Text = "AGE ABOVE 30";
            this.chkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Management",
            "Accounting",
            "Marketing",
            "Sales"});
            this.checkedListBox1.Location = new System.Drawing.Point(575, 161);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(164, 124);
            this.checkedListBox1.TabIndex = 11;
            // 
            // dgvAdd
            // 
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(747, 4);
            this.dgvAdd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowHeadersWidth = 51;
            this.dgvAdd.RowTemplate.Height = 24;
            this.dgvAdd.Size = new System.Drawing.Size(1080, 607);
            this.dgvAdd.TabIndex = 12;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(51, 317);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(94, 22);
            this.lbl_gender.TabIndex = 13;
            this.lbl_gender.Text = "GENDER";
            // 
            // lbl_chk
            // 
            this.lbl_chk.AutoSize = true;
            this.lbl_chk.Location = new System.Drawing.Point(571, 116);
            this.lbl_chk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chk.Name = "lbl_chk";
            this.lbl_chk.Size = new System.Drawing.Size(90, 22);
            this.lbl_chk.TabIndex = 14;
            this.lbl_chk.Text = "Degree In";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add Employee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1840, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_chk);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.dgvAdd);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chkBox1);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.txt_ph);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_ph);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ph;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_chk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

