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
    public partial class CopyRightDesignForm : Form
    {
        public Control ctrl;

        public CopyRightDesignForm(Control _ctrl)
        {
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            InitializeComponent();

            textBox1.Text = ctrl.Size.Height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(ctrl.Size.Width, Convert.ToInt32(textBox1.Text));
        }
    }
}
