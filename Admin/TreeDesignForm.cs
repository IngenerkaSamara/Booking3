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
    public partial class TreeDesignForm : Form
    {
        public Control ctrl;

        public TreeDesignForm(Control _ctrl)
        {
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            InitializeComponent();

            textBox1.Text = ctrl.Size.Width.ToString();
            textBox2.Text = ctrl.Size.Height.ToString();
        }

        private void TreeDesignForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(Convert.ToInt32(textBox1.Text), 
                Convert.ToInt32(textBox2.Text));
        }
    }
}
