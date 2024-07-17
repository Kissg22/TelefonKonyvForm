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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            string name = DeleteName.Text;
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
                            MobileNo = Int64.Parse(parts[4]),
                            Sex = parts[5],
                            Mail = parts[6],
                            CitizenNo = parts[7]
                        };
                        if (!p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            people.Add(p);
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
            }
            // Write remaining records
            using (StreamWriter writer = new StreamWriter("project.dat"))
            {
                foreach (var p in people)
                {
                    writer.WriteLine($"{p.Name},{p.Address},{p.FatherName},{p.MotherName},{p.MobileNo},{p.Sex},{p.Mail},{p.CitizenNo}");
                }
            }

            if (flag)
            {
                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("No contact's record to delete.");
            }

            this.Close();
        }


    }

    
}
