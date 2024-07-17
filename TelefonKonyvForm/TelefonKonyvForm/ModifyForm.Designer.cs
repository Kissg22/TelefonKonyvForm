namespace TelefonKonyvForm
{
    partial class ModifyForm
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
            this.btnModify_Click = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCitizenNo = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.CitizenNo = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.Label();
            this.MotherName = new System.Windows.Forms.Label();
            this.FatherName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModify_Click
            // 
            this.btnModify_Click.Location = new System.Drawing.Point(133, 366);
            this.btnModify_Click.Name = "btnModify_Click";
            this.btnModify_Click.Size = new System.Drawing.Size(75, 23);
            this.btnModify_Click.TabIndex = 0;
            this.btnModify_Click.Text = "Save";
            this.btnModify_Click.UseVisualStyleBackColor = true;
            this.btnModify_Click.Click += new System.EventHandler(this.btnModify_Click_Click);
            // 
            // SearchName
            // 
            this.SearchName.AutoSize = true;
            this.SearchName.Location = new System.Drawing.Point(291, 27);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(76, 13);
            this.SearchName.TabIndex = 16;
            this.SearchName.Text = "Keresett neve:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(133, 109);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(100, 20);
            this.txtFatherName.TabIndex = 30;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(133, 146);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(100, 20);
            this.txtMotherName.TabIndex = 29;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(133, 184);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNo.TabIndex = 28;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(133, 227);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(133, 257);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 26;
            // 
            // txtCitizenNo
            // 
            this.txtCitizenNo.Location = new System.Drawing.Point(133, 286);
            this.txtCitizenNo.Name = "txtCitizenNo";
            this.txtCitizenNo.Size = new System.Drawing.Size(100, 20);
            this.txtCitizenNo.TabIndex = 25;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(373, 24);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 33;
            // 
            // CitizenNo
            // 
            this.CitizenNo.AutoSize = true;
            this.CitizenNo.Location = new System.Drawing.Point(53, 289);
            this.CitizenNo.Name = "CitizenNo";
            this.CitizenNo.Size = new System.Drawing.Size(37, 13);
            this.CitizenNo.TabIndex = 41;
            this.CitizenNo.Text = "Város:";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(53, 260);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(29, 13);
            this.Mail.TabIndex = 40;
            this.Mail.Text = "Mail:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(53, 227);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(38, 13);
            this.Sex.TabIndex = 39;
            this.Sex.Text = "Neme:";
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSize = true;
            this.MobileNo.Location = new System.Drawing.Point(53, 184);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(46, 13);
            this.MobileNo.TabIndex = 38;
            this.MobileNo.Text = "Telefon:";
            // 
            // MotherName
            // 
            this.MotherName.AutoSize = true;
            this.MotherName.Location = new System.Drawing.Point(53, 153);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(63, 13);
            this.MotherName.TabIndex = 37;
            this.MotherName.Text = "Anyja neve:";
            // 
            // FatherName
            // 
            this.FatherName.AutoSize = true;
            this.FatherName.Location = new System.Drawing.Point(53, 109);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(58, 13);
            this.FatherName.TabIndex = 36;
            this.FatherName.Text = "Apja neve:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(53, 60);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(29, 13);
            this.Address.TabIndex = 35;
            this.Address.Text = "Cím:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(53, 24);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(30, 13);
            this.Name.TabIndex = 34;
            this.Name.Text = "Név:";
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 417);
            this.Controls.Add(this.CitizenNo);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.MotherName);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCitizenNo);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.btnModify_Click);
            this.Text = "ModifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify_Click;
        private System.Windows.Forms.Label SearchName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCitizenNo;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label CitizenNo;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label MobileNo;
        private System.Windows.Forms.Label MotherName;
        private System.Windows.Forms.Label FatherName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Name;
    }
}