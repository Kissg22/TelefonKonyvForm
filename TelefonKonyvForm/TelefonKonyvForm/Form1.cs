using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonKonyvForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            listForm.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.ShowDialog();
        }
    }
}
