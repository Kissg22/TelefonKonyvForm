using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TelefonKonyvForm
{
    public partial class ModifyForm : Form
    {
        private Person currentPerson;
        public ModifyForm()
        {
            InitializeComponent();
        }



        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentPerson == null)
            {
                MessageBox.Show("Please search for a record first.");
                return;
            }

            List<Person> people = new List<Person>();

            // Read all records
            using (StreamReader reader = new StreamReader("project.dat"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8)
                    {
                        Person p = new Person
                        {
                            Name = parts[0],
                            Address = parts[1],
                            FatherName = parts[2],
                            MotherName = parts[3],
                            MobileNo = Int64.TryParse(parts[4], out long mobileNo) ? mobileNo : 0,
                            Sex = parts[5],
                            Mail = parts[6],
                            CitizenNo = parts[7]
                        };

                        if (p.Name.Equals(currentPerson.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            p.Name = txtName.Text;
                            p.Address = txtAddress.Text;
                            p.FatherName = txtFatherName.Text;
                            p.MotherName = txtMotherName.Text;
                            p.MobileNo = Int64.TryParse(txtMobileNo.Text, out long newMobileNo) ? newMobileNo : 0;
                            p.Sex = txtSex.Text;
                            p.Mail = txtMail.Text;
                            p.CitizenNo = txtCitizenNo.Text;
                        }

                        people.Add(p);
                    }
                }
            }

            // Write updated records
            using (StreamWriter writer = new StreamWriter("project.dat"))
            {
                foreach (var p in people)
                {
                    writer.WriteLine($"{p.Name},{p.Address},{p.FatherName},{p.MotherName},{p.MobileNo},{p.Sex},{p.Mail},{p.CitizenNo}");
                }
            }

            MessageBox.Show("Record updated successfully");
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string nameToSearch = txtSearchName.Text;
            bool recordFound = false;

            using (StreamReader reader = new StreamReader("project.dat"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8)
                    {
                        Person p = new Person
                        {
                            Name = parts[0],
                            Address = parts[1],
                            FatherName = parts[2],
                            MotherName = parts[3],
                            MobileNo = Int64.TryParse(parts[4], out long mobileNo) ? mobileNo : 0,
                            Sex = parts[5],
                            Mail = parts[6],
                            CitizenNo = parts[7]
                        };

                        if (p.Name.Equals(nameToSearch, StringComparison.OrdinalIgnoreCase))
                        {
                            currentPerson = p;
                            txtName.Text = p.Name;
                            txtAddress.Text = p.Address;
                            txtFatherName.Text = p.FatherName;
                            txtMotherName.Text = p.MotherName;
                            txtMobileNo.Text = p.MobileNo.ToString();
                            txtSex.Text = p.Sex;
                            txtMail.Text = p.Mail;
                            txtCitizenNo.Text = p.CitizenNo;
                            recordFound = true;
                            break;
                        }
                    }
                }
            }

            if (!recordFound)
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}
