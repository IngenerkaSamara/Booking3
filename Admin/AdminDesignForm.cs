using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3.Admin
{
    public partial class AdminDesignForm : Form
    {
        #region ContextMenu
        /// <summary>
        /// Меню кнопок
        /// </summary>
        public static ContextMenuStrip BUTTON_CMS;
        #endregion

        #region TextBox
        /// <summary>
        /// Цвет текста текстбоксов
        /// </summary>
        public static Color TEXTBOX_FONT_COLOR;
        /// <summary>
        /// Шрифт текстбоксов
        /// </summary>
        public static Font TEXTBOX_FONT;
        #endregion

        #region Button
        /// <summary>
        /// Папка с картинками кнопок
        /// </summary>
        public static string BUTTON_PICS_DIR = "ButtonPics";
        /// <summary>
        /// Положение картинки кнопок
        /// </summary>
        public static ImageLayout BUTTON_LAYOUT;
        /// <summary>
        /// Картинка кнопок
        /// </summary>
        public static Image BUTTON_PICTURE;
        /// <summary>
        /// Адрес картинки кнопок
        /// </summary>
        public static string BUTTON_PICTURE_ADDRESS;
        /// <summary>
        /// Цвет кнопок
        /// </summary>
        public static Color BUTTON_COLOR;
        /// <summary>
        /// Цвет текста кнопок
        /// </summary>
        public static Color BUTTON_FONT_COLOR;
        /// <summary>
        /// Шрифт кнопок
        /// </summary>
        public static Font BUTTON_FONT;
        #endregion

        public AdminDesignForm()
        {
            InitializeComponent();
        }

        #region TextBox
        /// <summary>
        /// Выбор шрифта у текстбоксов
        /// </summary>
        private void TextBoxFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TEXTBOX_FONT;
            fontDialog1.Color = TEXTBOX_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_FONT = fontDialog1.Font;
                TEXTBOX_FONT_COLOR = fontDialog1.Color;

                AdminDesignForm_Load(null, null);
            }
        }
        #endregion

        /// <summary>
        /// Чтение дизайна из БД
        /// </summary>
        public static void ReadDefaultDesign()
        {
            //Картинка
            try
            {
                BUTTON_PICTURE_ADDRESS =
                    SQLClass.Select("SELECT value FROM defaultdesign" +
                    " WHERE type = 'System.Windows.Forms.Button' AND parameter='PICTURE_ADDRESS'")[0];
                BUTTON_PICTURE = Image.FromFile(BUTTON_PICS_DIR + "\\" + BUTTON_PICTURE_ADDRESS);
            }
            catch (Exception) { }

            //Шрифт
            try
            {
                string color =
                    SQLClass.Select("SELECT value FROM defaultdesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='FONT_COLOR'")[0];

                BUTTON_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));

                string font =
                    SQLClass.Select("SELECT value FROM defaultdesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='FONT'")[0];

                string[] parts = font.Split(new char[] { ';' });

                BUTTON_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            //Цвет
            try
            {
                string color =
                    SQLClass.Select("SELECT value FROM defaultdesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='COLOR'")[0];

                BUTTON_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            //Положение картинки
            try
            {
                string layout =
                    SQLClass.Select("SELECT value FROM defaultdesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='LAYOUT'")[0];

                if (layout == "Center")
                    BUTTON_LAYOUT = ImageLayout.Center;
                else if (layout == "None")
                    BUTTON_LAYOUT = ImageLayout.None;
                else if (layout == "Stretch")
                    BUTTON_LAYOUT = ImageLayout.Stretch;
                else if (layout == "Tile")
                    BUTTON_LAYOUT = ImageLayout.Tile;
                else if (layout == "Zoom")
                    BUTTON_LAYOUT = ImageLayout.Zoom;
            }
            catch (Exception) { }
        }
        
        /// <summary>
        /// ЧТение дизайна кнопки из БД
        /// </summary>
        public static void ReadUniqueButtonDesign(Button btn)
        {
            //Ищем родительскую форму/UserControl
            Control parent = btn;
            while (!(parent is Form || parent is UserControl))
            {
                parent = parent.Parent;
            }

            //Картинка
            try
            {
                string address =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button' AND parameter='PICTURE_ADDRESS'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];
                btn.BackgroundImage = Image.FromFile(BUTTON_PICS_DIR + "\\" + address);
            }
            catch (Exception) { }

            //Положение
            try
            {
                string location =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button' AND parameter='LOCATION'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];
                string[] parts = location.Split(new char[] { ',' });
                btn.Location = new Point(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }

            //Доступность админу
            try
            {
                string admin =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button' AND parameter='ADMIN'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];
                btn.AccessibleDescription = admin;
            }
            catch (Exception) { }

            //Размер
            try
            {
                string location =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button' AND parameter='SIZE'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];
                string[] parts = location.Split(new char[] { ',' });
                btn.Size = new Size(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }

            //Шрифт
            try
            {
                string color =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='FONT_COLOR'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];

                btn.ForeColor = Color.FromArgb(Convert.ToInt32(color));

                string font =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='FONT'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];

                string[] parts = font.Split(new char[] { ';' });

                btn.Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            //Цвет
            try
            {
                string color =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='COLOR'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];

                btn.BackColor = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            //Положение картинки
            try
            {
                string layout =
                    SQLClass.Select("SELECT value FROM uniqueDesign" +
                    " WHERE type = 'System.Windows.Forms.Button'" +
                    " AND parameter='LAYOUT'" +
                    " AND name='" + btn.Name + "'" +
                    " AND form='" + parent.Name + "'")[0];

                if (layout == "Center")
                    btn.BackgroundImageLayout = ImageLayout.Center;
                else if (layout == "None")
                    btn.BackgroundImageLayout = ImageLayout.None;
                else if (layout == "Stretch")
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                else if (layout == "Tile")
                    btn.BackgroundImageLayout = ImageLayout.Tile;
                else if (layout == "Zoom")
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Меню ко всем кнопкам, текстбоксам формы
        /// </summary>
        public static void ApplyMenu(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if (ctrl is Button && Booking3.MainForm.IsAdmin)
                {
                    ctrl.ContextMenuStrip = BUTTON_CMS;
                }
                else
                    ApplyMenu(ctrl);
            }
        }
        
        /// <summary>
        /// Применение дизайна ко всем кнопкам, текстбоксам формы
        /// </summary>
        public static void ApplyDesign(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                #region Дизайн кнопок
                if (ctrl is Button)
                {
                    ctrl.Font = BUTTON_FONT;
                    ctrl.ForeColor = BUTTON_FONT_COLOR;
                    ctrl.BackColor = BUTTON_COLOR;
                    ctrl.BackgroundImage = BUTTON_PICTURE;
                    ctrl.BackgroundImageLayout = BUTTON_LAYOUT;
                    ReadUniqueButtonDesign((Button)ctrl);

                    //Скрываем кнопку, если она только для админов, а мы не он)
                    if (!MainForm.IsAdmin && ctrl.AccessibleDescription == "1")
                        ctrl.Visible = false;
                    else
                        ctrl.Visible = true;
                }
                #endregion
                else
                    ApplyDesign(ctrl);
            }
        }
        
        private void AdminDesignForm_Load(object sender, EventArgs e)
        {
            textBox1.Font = TEXTBOX_FONT;
            textBox1.ForeColor = TEXTBOX_FONT_COLOR;

            button1.Font = BUTTON_FONT;
            button1.ForeColor = BUTTON_FONT_COLOR;
            button1.BackColor = BUTTON_COLOR;
            button1.BackgroundImage = BUTTON_PICTURE;
            button1.BackgroundImageLayout = BUTTON_LAYOUT;
        }

        #region Button
        /// <summary>
        /// Шрифт кнопок
        /// </summary>
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = BUTTON_FONT;
            fontDialog1.Color = BUTTON_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_FONT = fontDialog1.Font;
                BUTTON_FONT_COLOR = fontDialog1.Color;

                AdminDesignForm_Load(null, null);

                SQLClass.Update("DELETE FROM defaultDesign" +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND parameter='FONT'");
                SQLClass.Update("DELETE FROM defaultDesign" +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND parameter='FONT_COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign" +
                    "(type, parameter, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'FONT', " +
                    "'" + BUTTON_FONT.Name + ";" + BUTTON_FONT.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultDesign" +
                    "(type, parameter, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'FONT_COLOR', " +
                    "'" + BUTTON_FONT_COLOR.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Цвет кнопок
        /// </summary>
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BUTTON_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_COLOR = colorDialog1.Color;

                AdminDesignForm_Load(null, null);

                SQLClass.Update("DELETE FROM defaultDesign" +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND parameter='COLOR'");

                SQLClass.Update("INSERT INTO defaultDesign" +
                    "(type, parameter, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'COLOR', " +
                    "'" + BUTTON_COLOR.ToArgb() + "')");
            }
        }

        /// <summary>
        /// Выбор картинки кнопок
        /// </summary>
        private void ButtonPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = 
                Path.GetDirectoryName(Application.ExecutablePath) + "\\" + BUTTON_PICS_DIR;
            openFileDialog1.FileName = BUTTON_PICTURE_ADDRESS;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (BUTTON_PICTURE_ADDRESS != openFileDialog1.FileName)
                {
                    if (Path.GetDirectoryName(openFileDialog1.FileName) != openFileDialog1.InitialDirectory)
                        File.Copy(openFileDialog1.FileName, openFileDialog1.InitialDirectory + "\\" + openFileDialog1.SafeFileName);

                    BUTTON_PICTURE_ADDRESS = openFileDialog1.SafeFileName;
                    BUTTON_PICTURE = Image.FromFile(BUTTON_PICS_DIR + "\\" + BUTTON_PICTURE_ADDRESS);
                }                

                AdminDesignForm_Load(null, null);

                SQLClass.Update("DELETE FROM defaultDesign" +
                    " WHERE type='" + button1.GetType() + "'" +
                    " AND parameter='PICTURE_ADDRESS'");

                SQLClass.Update("INSERT INTO defaultDesign" +
                    "(type, parameter, value) values (" +
                    "'" + button1.GetType() + "', " +
                    "'PICTURE_ADDRESS', " +
                    "'" + BUTTON_PICTURE_ADDRESS + "')");
            }
        }

        /// <summary>
        /// Удаление картинки
        /// </summary>
        private void ButtonDeletePictureButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM defaultDesign" +
                " WHERE type='" + button1.GetType() + "'" +
                " AND parameter='PICTURE_ADDRESS'");
        }

        /// <summary>
        /// Выбор положения картинки
        /// </summary>
        private void ButtonLayoutCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ButtonLayoutCombo.SelectedIndex == 0)
                BUTTON_LAYOUT = ImageLayout.None;
            else if (ButtonLayoutCombo.SelectedIndex == 1)
                BUTTON_LAYOUT = ImageLayout.Tile;
            else if (ButtonLayoutCombo.SelectedIndex == 2)
                BUTTON_LAYOUT = ImageLayout.Stretch;
            else if (ButtonLayoutCombo.SelectedIndex == 3)
                BUTTON_LAYOUT = ImageLayout.Zoom;
            else if (ButtonLayoutCombo.SelectedIndex == 4)
                BUTTON_LAYOUT = ImageLayout.Center;
            
            AdminDesignForm_Load(null, null);


            SQLClass.Update("DELETE FROM defaultDesign" +
                " WHERE type='" + button1.GetType() + "'" +
                " AND parameter='LAYOUT'");

            SQLClass.Update("INSERT INTO defaultDesign" +
                "(type, parameter, value) values (" +
                "'" + button1.GetType() + "', " +
                "'LAYOUT', " +
                "'" + BUTTON_LAYOUT.ToString() + "')");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
