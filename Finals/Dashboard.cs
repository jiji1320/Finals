using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfile myprofile = new MyProfile();
            myprofile.FormClosed += (s, args) => this.Close();
            myprofile.Show();
        }

      
        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 230)
            {
                MenuVertical.Width = 40;
            }
            else
            {
                MenuVertical.Width = 230;
            }
        }
    }
}
