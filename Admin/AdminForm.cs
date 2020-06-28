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
    public partial class AdminForm : UserControl
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHotelsForm af = new AdminHotelsForm();
            Controls.Clear();
            Controls.Add(af);
            af.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRoomsForm af = new AdminRoomsForm();
            Controls.Clear();
            Controls.Add(af);
            af.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUsersForm af = new AdminUsersForm();
            Controls.Clear();
            Controls.Add(af);
            af.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminBookingForm af = new AdminBookingForm();
            Controls.Clear();
            Controls.Add(af);
            af.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogForm af = new AdminLogForm();
            Controls.Clear();
            Controls.Add(af);
            af.Dock = DockStyle.Fill;
        }
    }
}
