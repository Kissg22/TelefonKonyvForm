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
            Person p;
            using (StreamReader reader = new StreamReader("project.dat"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 8) // Ensure all fields are present
                    {
                        p.Name = parts[0];
                        p.Address = parts[1];
                        p.FatherName = parts[2];
                        p.MotherName = parts[3];
                        p.MobileNo = Int64.Parse(parts[4]);
                        p.Sex = parts[5];
                        p.Mail = parts[6];
                        p.CitizenNo = parts[7];

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
