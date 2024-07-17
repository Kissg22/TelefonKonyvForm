using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonKonyvForm
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
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
                            MobileNo = Int64.Parse(parts[4]),
                            Sex = parts[5],
                            Mail = parts[6],
                            CitizenNo = parts[7]
                        };

                        if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            lblResult.Text = $"Name: {p.Name}\nAddress: {p.Address}\nFather's Name: {p.FatherName}\nMother's Name: {p.MotherName}\nMobile No: {p.MobileNo}\nSex: {p.Sex}\nEmail: {p.Mail}\nCitizen No: {p.CitizenNo}";
                            recordFound = true;
                            break;
                        }
                    }
                }
            }

            if (!recordFound)
            {
                lblResult.Text = "Record not found";
            }
        }
    }
}

