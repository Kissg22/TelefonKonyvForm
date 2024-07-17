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
            Person p = new Person();
            bool flag = false;
            string name = DeleteName.Text;

            using (FileStream fs = new FileStream("project.dat", FileMode.OpenOrCreate))
            using (BinaryReader reader = new BinaryReader(fs))
            using (FileStream tempFs = new FileStream("temp.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(tempFs))
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

                    if (!p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        writer.Write(p.Name);
                        writer.Write(p.Address);
                        writer.Write(p.FatherName);
                        writer.Write(p.MotherName);
                        writer.Write(p.MobileNo);
                        writer.Write(p.Sex);
                        writer.Write(p.Mail);
                        writer.Write(p.CitizenNo);
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                File.Delete("project.dat");
                File.Move("temp.dat", "project.dat");
                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("No contact's record to delete.");
                File.Delete("temp.dat");
            }

            this.Close();
        }
    }
}
