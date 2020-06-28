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

        private void AdminDesignForm_Load(object sender, EventArgs e)
        {
            textBox1.Font = TEXTBOX_FONT;
            textBox1.ForeColor = TEXTBOX_FONT_COLOR;

            button1.Font = BUTTON_FONT;
            button1.ForeColor = BUTTON_FONT_COLOR;
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
        #endregion
    }
}
