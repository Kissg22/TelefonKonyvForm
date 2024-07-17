namespace TelefonKonyvForm
{
    partial class DeleteForm
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
            this.txtDeleteName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DeleteName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.AutoSize = true;
            this.txtDeleteName.Location = new System.Drawing.Point(43, 101);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(103, 13);
            this.txtDeleteName.TabIndex = 0;
            this.txtDeleteName.Text = "Törölni kívánt neve:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(144, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // DeleteName
            // 
            this.DeleteName.Location = new System.Drawing.Point(196, 98);
            this.DeleteName.Name = "DeleteName";
            this.DeleteName.Size = new System.Drawing.Size(100, 20);
            this.DeleteName.TabIndex = 2;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 339);
            this.Controls.Add(this.DeleteName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeleteName);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDeleteName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox DeleteName;
    }
}