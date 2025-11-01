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
    public partial class SignOut : Form
    {
        public SignOut()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 230)
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
