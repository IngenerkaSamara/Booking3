using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3.Admin
{
    public partial class UniqueButton : Form
    {
        public UniqueButton(Button btn)
        {
            InitializeComponent();

            button1.Text = btn.Text;
            button1.BackColor = btn.BackColor;
        }

        private void UniqueButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
