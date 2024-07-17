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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            LoadRecords();
        }
        private void LoadRecords()
        {
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

                        lstRecords.Items.Add($"Name: {p.Name}, Address: {p.Address}, Phone: {p.MobileNo}");
                    }
                    else
                    {
                        // Handle invalid data format or incomplete records
                        Console.WriteLine("Invalid data format encountered.");
                    }
                }
            }
        }

    }
}
