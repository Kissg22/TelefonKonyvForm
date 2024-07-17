using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TelefonKonyvForm
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void btnModify_Click_Click(object sender, EventArgs e)
        {
            string nameToSearch = txtSearchName.Text;
            bool recordFound = false;

            List<Person> updatedRecords = new List<Person>();

            using (FileStream fs = new FileStream("project.dat", FileMode.OpenOrCreate))
            using (BinaryReader reader = new BinaryReader(fs))
            using (FileStream tempFs = new FileStream("temp.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(tempFs))
            {
                while (fs.Position < fs.Length)
                {
                    Person p = new Person();
                    p.Name = reader.ReadString();
                    p.Address = reader.ReadString();
                    p.FatherName = reader.ReadString();
                    p.MotherName = reader.ReadString();
                    p.MobileNo = reader.ReadInt64();
                    p.Sex = reader.ReadString();
                    p.Mail = reader.ReadString();
                    p.CitizenNo = reader.ReadString();

                    if (p.Name.Equals(nameToSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        // Update fields from textboxes
                        p.Name = txtName.Text;
                        p.Address = txtAddress.Text;
                        p.FatherName = txtFatherName.Text;
                        p.MotherName = txtMotherName.Text;
                        p.MobileNo = Int64.Parse(txtMobileNo.Text);
                        p.Sex = txtSex.Text;
                        p.Mail = txtMail.Text;
                        p.CitizenNo = txtCitizenNo.Text;

                        recordFound = true;
                    }

                    updatedRecords.Add(p);
                }
                fs.Seek(0, SeekOrigin.Begin);
            }

            // Rewrite the original file with updated records from the list
            using (FileStream fs = new FileStream("project.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                foreach (Person person in updatedRecords)
                {
                    writer.Write(person.Name);
                    writer.Write(person.Address);
                    writer.Write(person.FatherName);
                    writer.Write(person.MotherName);
                    writer.Write(person.MobileNo);
                    writer.Write(person.Sex);
                    writer.Write(person.Mail);
                    writer.Write(person.CitizenNo);
                }
            }

            // Delete temporary file
            File.Delete("temp.dat");

            if (recordFound)
            {
                MessageBox.Show("Record updated successfully");
            }
            else
            {
                MessageBox.Show("Record not found");
            }

            this.Close();
        }
    }
}
