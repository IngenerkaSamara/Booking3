using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class AdminDesignForm : Form
    {
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
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = BUTTON_FONT;
            fontDialog1.Color = BUTTON_FONT_COLOR;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_FONT = fontDialog1.Font;
                BUTTON_FONT_COLOR = fontDialog1.Color;

                AdminDesignForm_Load(null, null);
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
            }
        }

        /// <summary>
        /// Выбор картинки кнопок
        /// </summary>
        private void ButtonPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = BUTTON_PICTURE_ADDRESS;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (BUTTON_PICTURE_ADDRESS != openFileDialog1.FileName)
                {
                    BUTTON_PICTURE_ADDRESS = openFileDialog1.FileName;
                    BUTTON_PICTURE = Image.FromFile(BUTTON_PICTURE_ADDRESS);
                }                

                AdminDesignForm_Load(null, null);
            }

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
        }
        #endregion
    }
}
