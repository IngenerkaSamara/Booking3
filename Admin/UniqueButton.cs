using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Booking3.Admin
{
    public partial class UniqueButton : Form
    {
        Button btn;
        Control parent;
        string address = "";

        public UniqueButton(Button _btn, Control _parent)
        {
            InitializeComponent();
            btn = _btn;
            parent = _parent;

            button1.Text = btn.Text;
            button1.BackColor = btn.BackColor;
            button1.ForeColor = btn.ForeColor;
            button1.BackgroundImageLayout = btn.BackgroundImageLayout;
            button1.BackgroundImage = btn.BackgroundImage;
            button1.Font = btn.Font;
            button1.Size = btn.Size;

            ButtonCoordsTextBox.Text = btn.Location.X.ToString() + ", " + btn.Location.Y.ToString();
            ButtonSizeTextBox.Text = btn.Size.Width.ToString() + ", " + btn.Size.Height.ToString();
        }

        private void UniqueButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region Button
        /// <summary>
        /// Шрифт кнопок
        /// </summary>
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button1.Font;
            fontDialog1.Color = button1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Font = fontDialog1.Font;
                button1.ForeColor = fontDialog1.Color;

                UniqueButton_Load(null, null);

                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'" +
                    " AND parameter='FONT'");
                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'" +
                    " AND parameter='FONT_COLOR'");

                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                    "(type, parameter, name, form, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'FONT', " +
                    "'" + btn.Name + "', " +
                    "'" + parent.Name + "', " +
                    "'" + button1.Font.Name + ";" + button1.Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                    "(type, parameter, name, form, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'FONT_COLOR', " +
                    "'" + btn.Name + "', " +
                    "'" + parent.Name + "', " +
                    "'" + button1.ForeColor.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Цвет кнопок
        /// </summary>
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button1.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;

                UniqueButton_Load(null, null);

                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'" +
                    " AND parameter='COLOR'");

                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                    "(type, parameter, name, form, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'COLOR', " +
                    "'" + btn.Name + "', " +
                    "'" + parent.Name + "', " +
                    "'" + button1.BackColor.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Выбор картинки кнопок
        /// </summary>
        private void ButtonPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory =
                Path.GetDirectoryName(Application.ExecutablePath) + "\\" + 
                AdminDesignForm.BUTTON_PICS_DIR;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetDirectoryName(openFileDialog1.FileName) != openFileDialog1.InitialDirectory)
                    File.Copy(openFileDialog1.FileName, openFileDialog1.InitialDirectory + "\\" + openFileDialog1.SafeFileName);

                address = openFileDialog1.SafeFileName;
                button1.BackgroundImage = Image.FromFile(AdminDesignForm.BUTTON_PICS_DIR + "\\" + address);

                UniqueButton_Load(null, null);

                SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'" +
                    " AND parameter='PICTURE_ADDRESS'");

                SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                    "(type, parameter, name, form, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'PICTURE_ADDRESS', " +
                    "'" + btn.Name + "', " +
                    "'" + parent.Name + "', " +
                    "'" + address + "')");
            }
        }

        /// <summary>
        /// Удаление картинки
        /// </summary>
        private void ButtonDeletePictureButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                " WHERE type='" + button1.GetType() + "'" +
                " AND name='" + btn.Name + "'" +
                " AND form='" + parent.Name + "'" +
                " AND parameter='PICTURE_ADDRESS'");
        }

        /// <summary>
        /// Выбор положения картинки
        /// </summary>
        private void ButtonLayoutCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ButtonLayoutCombo.SelectedIndex == 0)
                button1.BackgroundImageLayout = ImageLayout.None;
            else if (ButtonLayoutCombo.SelectedIndex == 1)
                button1.BackgroundImageLayout = ImageLayout.Tile;
            else if (ButtonLayoutCombo.SelectedIndex == 2)
                button1.BackgroundImageLayout = ImageLayout.Stretch;
            else if (ButtonLayoutCombo.SelectedIndex == 3)
                button1.BackgroundImageLayout = ImageLayout.Zoom;
            else if (ButtonLayoutCombo.SelectedIndex == 4)
                button1.BackgroundImageLayout = ImageLayout.Center;

            UniqueButton_Load(null, null);


            SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                " WHERE type='" + button1.GetType() + "'" +
                " AND name='" + btn.Name + "'" +
                " AND form='" + parent.Name + "'" +
                " AND parameter='LAYOUT'");

            SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                "(type, parameter, name, form, value) values (" +
                "'" + button1.GetType() + "', " +
                "'LAYOUT', " +
                "'" + btn.Name + "', " +
                "'" + parent.Name + "', " +
                "'" + button1.BackgroundImageLayout.ToString() + "')");
        }

        /// <summary>
        /// Сохранение положения и координат
        /// </summary>
        private void SaveCoordsButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                " WHERE type='" + button1.GetType() + "'" +
                " AND name='" + btn.Name + "'" +
                " AND form='" + parent.Name + "'" +
                " AND parameter='LOCATION'");
            SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                " WHERE type='" + button1.GetType() + "'" +
                " AND name='" + btn.Name + "'" +
                " AND form='" + parent.Name + "'" +
                " AND parameter='SIZE'");

            SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                "(type, parameter, name, form, value) values (" +
                "'" + button1.GetType() + "', " +
                "'LOCATION', " +
                "'" + btn.Name + "', " +
                "'" + parent.Name + "', " +
                "'" + ButtonCoordsTextBox.Text + "')");
            SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                "(type, parameter, name, form, value) values (" +
                "'" + button1.GetType() + "', " +
                "'SIZE', " +
                "'" + btn.Name + "', " +
                "'" + parent.Name + "', " +
                "'" + ButtonSizeTextBox.Text + "')");
        }

        /// <summary>
        /// Доступность всем или админу
        /// </summary>
        private void ButtonAdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM " + SQLClass.UNIQUE_DESIGN +
                   " WHERE type='" + button1.GetType() + "'" +
                   " AND name='" + btn.Name + "'" +
                   " AND form='" + parent.Name + "'" +
                   " AND parameter='ADMIN'");

            SQLClass.Update("INSERT INTO " + SQLClass.UNIQUE_DESIGN +
                "(type, parameter, name, form, value) values (" +
                "'" + button1.GetType() + "', " +
                "'ADMIN', " +
                "'" + btn.Name + "', " +
                "'" + parent.Name + "', " +
                "'" + ((ButtonAdminCheckBox.Checked) ? "1": "0") + "')");
        }

        #endregion
    }
}
