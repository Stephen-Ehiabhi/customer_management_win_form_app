
namespace _1
{
    partial class AddStaffForm
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
            this.btnImportImg = new System.Windows.Forms.Button();
            this.PicBoxStaff = new System.Windows.Forms.PictureBox();
            this.comborole = new System.Windows.Forms.ComboBox();
            this.TBadress = new System.Windows.Forms.TextBox();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBContact = new System.Windows.Forms.TextBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TBfname = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportImg
            // 
            this.btnImportImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(175)))));
            this.btnImportImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportImg.Font = new System.Drawing.Font("Ambit SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportImg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportImg.Location = new System.Drawing.Point(586, 366);
            this.btnImportImg.Name = "btnImportImg";
            this.btnImportImg.Size = new System.Drawing.Size(207, 40);
            this.btnImportImg.TabIndex = 44;
            this.btnImportImg.Text = "Import Image";
            this.btnImportImg.UseVisualStyleBackColor = false;
            this.btnImportImg.Click += new System.EventHandler(this.btnImportImg_Click);
            this.btnImportImg.MouseLeave += new System.EventHandler(this.btnImportImg_MouseLeave);
            this.btnImportImg.MouseHover += new System.EventHandler(this.btnImportImg_MouseHover);
            // 
            // PicBoxStaff
            // 
            this.PicBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxStaff.Image = global::_1.Properties.Resources.Default;
            this.PicBoxStaff.Location = new System.Drawing.Point(555, 156);
            this.PicBoxStaff.Name = "PicBoxStaff";
            this.PicBoxStaff.Size = new System.Drawing.Size(252, 199);
            this.PicBoxStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxStaff.TabIndex = 42;
            this.PicBoxStaff.TabStop = false;
            // 
            // comborole
            // 
            this.comborole.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborole.FormattingEnabled = true;
            this.comborole.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Officer",
            "Accountant"});
            this.comborole.Location = new System.Drawing.Point(179, 374);
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(357, 30);
            this.comborole.TabIndex = 41;
            // 
            // TBadress
            // 
            this.TBadress.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBadress.Location = new System.Drawing.Point(179, 326);
            this.TBadress.Name = "TBadress";
            this.TBadress.Size = new System.Drawing.Size(357, 29);
            this.TBadress.TabIndex = 38;
            // 
            // TBemail
            // 
            this.TBemail.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(179, 285);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(357, 29);
            this.TBemail.TabIndex = 37;
            // 
            // TBContact
            // 
            this.TBContact.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TBContact.Location = new System.Drawing.Point(179, 242);
            this.TBContact.Name = "TBContact";
            this.TBContact.Size = new System.Drawing.Size(357, 29);
            this.TBContact.TabIndex = 36;
            // 
            // TBlastname
            // 
            this.TBlastname.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBlastname.Location = new System.Drawing.Point(179, 200);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(357, 29);
            this.TBlastname.TabIndex = 35;
            // 
            // TBfname
            // 
            this.TBfname.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBfname.Location = new System.Drawing.Point(179, 156);
            this.TBfname.Name = "TBfname";
            this.TBfname.Size = new System.Drawing.Size(357, 29);
            this.TBfname.TabIndex = 40;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(175)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Ambit SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(670, 470);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 43);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnImportImg_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnImportImg_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(175)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Ambit SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(23, 470);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 43);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnImportImg_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnImportImg_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Contact :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Last name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "First name :";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(737, 122);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(17, 22);
            this.lblStaffID.TabIndex = 23;
            this.lblStaffID.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ambit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Staff ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ambit", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Staff";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Ming", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(827, 47);
            this.label3.TabIndex = 45;
            this.label3.Text = "SWIRE BANK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(188)))));
            this.BackgroundImage = global::_1.Properties.Resources.arches__1_;
            this.ClientSize = new System.Drawing.Size(827, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImportImg);
            this.Controls.Add(this.PicBoxStaff);
            this.Controls.Add(this.comborole);
            this.Controls.Add(this.TBadress);
            this.Controls.Add(this.TBemail);
            this.Controls.Add(this.TBContact);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.TBfname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStaffForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff Member";
            this.Load += new System.EventHandler(this.staffFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImportImg;
        private System.Windows.Forms.PictureBox PicBoxStaff;
        private System.Windows.Forms.ComboBox comborole;
        private System.Windows.Forms.TextBox TBadress;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TBContact;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TBfname;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}