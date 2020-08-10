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
        /// <summary>
        /// Наш блок
        /// </summary>
        public Control ctrl;

        /// <summary>
        /// Родительский ЮзерКонтрол
        /// </summary>
        public Control parent;

        public TreeDesignForm(Control _ctrl)
        {
            //Ищем родительскую форму/UserControl
            parent = _ctrl;
            while (!(parent is Form || parent is UserControl))
            {
                parent = parent.Parent;
            }

            //Копируем основные параметры
            ctrl = new Control();
            ctrl.Size = _ctrl.Size;
            ctrl.Name = _ctrl.Name;

            InitializeComponent();

            //Заполняем параметры
            WidthTextBox.Text = ctrl.Size.Width.ToString();
            HeightTextBox.Text = ctrl.Size.Height.ToString();

            CopyRightCLB.Visible = (ctrl.Name == "CopyRightPanel");
            if (ctrl.Name == "CopyRightPanel")
            {
                try
                {
                    string vk =
                        SQLClass.Select(
                            "SELECT value FROM " + SQLClass.BLOCK_DESIGN +
                        " WHERE parameter='VK'" +
                        " AND name='" + ctrl.Name + "'" +
                        " AND form='" + parent.Name + "'")[0];

                    if (vk == "1")
                        CopyRightCLB.SetItemChecked(0, true);

                    string insta =
                        SQLClass.Select(
                            "SELECT value FROM " + SQLClass.BLOCK_DESIGN +
                        " WHERE parameter='Insta'" +
                        " AND name='" + ctrl.Name + "'" +
                        " AND form='" + parent.Name + "'")[0];

                    if (insta == "1")
                        CopyRightCLB.SetItemChecked(1, true);
                }
                catch (Exception) { }
            }
        }

        private void TreeDesignForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Удаление параметра
        /// </summary>
        void DeleteBlockDesign(string par)
        {
            SQLClass.Update("DELETE FROM " + SQLClass.BLOCK_DESIGN +
                " WHERE name='" + ctrl.Name + "'" +
                " AND form='" + parent.Name + "'" +
                " AND parameter='" + par + "'");
        }

        /// <summary>
        /// Добавление параметра
        /// </summary>
        void InsertBlockParam(string par, string value)
        {
            SQLClass.Update("INSERT INTO " + SQLClass.BLOCK_DESIGN +
                "(parameter, name, form, value) values (" +
                "'" + par + "', " +
                "'" + ctrl.Name + "', " +
                "'" + parent.Name + "', " +
                "'" + value + "')");
        }

        /// <summary>
        /// Сохранение положения и координат
        /// </summary>
        private void SaveCoordsButton_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(Convert.ToInt32(WidthTextBox.Text),
                Convert.ToInt32(HeightTextBox.Text));

            DeleteBlockDesign("WIDTH");
            DeleteBlockDesign("HEIGHT");
            DeleteBlockDesign("VK");
            DeleteBlockDesign("Insta");

            InsertBlockParam("WIDTH", WidthTextBox.Text);
            InsertBlockParam("HEIGHT", HeightTextBox.Text);

            foreach (object item in CopyRightCLB.CheckedItems)
            {
                if (item.ToString() == "VK")
                    InsertBlockParam("VK", "1");
                if (item.ToString() == "Insta")
                    InsertBlockParam("Insta", "1");
            }
        }
    }
}
