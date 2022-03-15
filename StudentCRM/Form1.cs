using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if ( result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("It loads beautifily");
        }
    }
}
