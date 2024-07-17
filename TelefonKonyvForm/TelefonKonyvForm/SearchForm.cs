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

            Person p = new Person();
            string name = txtSearchName.Text;
            bool recordFound = false;

            using (FileStream fs = new FileStream("project.dat", FileMode.OpenOrCreate))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    p.Name = reader.ReadString();
                    p.Address = reader.ReadString();
                    p.FatherName = reader.ReadString();
                    p.MotherName = reader.ReadString();
                    p.MobileNo = reader.ReadInt64();
                    p.Sex = reader.ReadString();
                    p.Mail = reader.ReadString();
                    p.CitizenNo = reader.ReadString();

                    if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        lblResult.Text = $"Name: {p.Name}\nAddress: {p.Address}\nFather's Name: {p.FatherName}\nMother's Name: {p.MotherName}\nMobile No: {p.MobileNo}\nSex: {p.Sex}\nEmail: {p.Mail}\nCitizen No: {p.CitizenNo}";
                        recordFound = true;
                        break;
                    }
                }

                if (!recordFound)
                {
                    lblResult.Text = "Record not found";
                }
            }
        }
    }
}
