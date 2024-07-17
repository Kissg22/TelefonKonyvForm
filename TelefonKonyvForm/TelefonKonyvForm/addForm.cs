using System;
using System.IO;
using System.Windows.Forms;

namespace TelefonKonyvForm
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Person p = new Person
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                MobileNo = Int64.Parse(txtMobileNo.Text),
                Sex = txtSex.Text,
                Mail = txtMail.Text,
                CitizenNo = txtCitizenNo.Text
            };

            using (StreamWriter writer = new StreamWriter("project.dat", true))
            {
                writer.WriteLine($"{p.Name},{p.Address},{p.FatherName},{p.MotherName},{p.MobileNo},{p.Sex},{p.Mail},{p.CitizenNo}");
            }

            MessageBox.Show("Record saved");
            this.Close();
        }
    }
}
