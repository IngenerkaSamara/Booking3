using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3.UserControls
{
    public partial class SocialUC : UserControl
    {
        public SocialUC()
        {
            InitializeComponent();
            ContextMenuStrip = Admin.AdminDesignForm.BLOCK_CMS;
        }

        private void VKPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/dtci_ru");
        }

        private void InstaPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ingenerka_73/");
        }

        private void CopyRightPanel_Resize(object sender, EventArgs e)
        {
            InstaPictureBox.Size = new Size(CopyRightLabel.Size.Height, CopyRightLabel.Size.Height);
            VKPictureBox.Size = InstaPictureBox.Size;
        }

        private void SocialUC_Load(object sender, EventArgs e)
        {
        }
    }
}
