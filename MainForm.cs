using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Booking3
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public static string Login = "";

        /// <summary>
        /// Админ ли в системе
        /// </summary>
        public static bool IsAdmin = false;
               
        public MainForm()
        {
            InitializeComponent();

            UserControls.HotelsListUC listUC = new UserControls.HotelsListUC();
            listUC.Dock = DockStyle.Fill;
            HotelsPanel.Controls.Clear();
            HotelsPanel.Controls.Add(listUC);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> cities = SQLClass.Select("SELECT DISTINCT name FROM cities ORDER BY name");
            foreach (string city in cities)
            {
                TreeNode node = new TreeNode(city);
                treeView1.Nodes[0].Nodes.Add(node);


                List<string> hotels = SQLClass.Select(
                    "SELECT DISTINCT name FROM hotels" +
                    " WHERE city='" + node.Text + "' ORDER BY name");
                foreach (string hotel in hotels)
                {
                    TreeNode node2 = new TreeNode(hotel);
                    node.Nodes.Add(node2);

                    List<string> rooms = SQLClass.Select(
                        "SELECT DISTINCT name FROM room" +
                        " WHERE hotel='" + node2.Text + "' ORDER BY name");
                    foreach (string room in rooms)
                    {
                        TreeNode node3 = new TreeNode(room);
                        node2.Nodes.Add(node3);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            //Вход
            if (Login == "")
            {
                List<string> user_data = SQLClass.Select(
                    "SELECT admin FROM users WHERE Login = '" + LoginTextBox.Text +
                    "' AND Password = '" + PasswordTextBox.Text + "'");

                //Авторизация успешна
                if (user_data.Count > 0)
                {
                    //Глобальные переменные
                    Login = LoginTextBox.Text;
                    IsAdmin = (user_data[0] == "1");

                    //Компоненты на форме
                    AuthPanel.Controls.Clear();
                    AdminButton.Visible = (user_data[0] == "1");
                    AuthPanel.Controls.Add(AdminButton);

                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Text = "Привет, " + Login;

                    AuthPanel.Controls.Add(LoginButton);
                    LoginButton.Text = "Выход";

                    AuthPanel.Controls.Add(AccountButton);
                    AccountButton.Visible = true;
                }
                else
                {
                    user_data = SQLClass.Select(
                        "SELECT * FROM users WHERE Login = '" + LoginTextBox.Text + "'");

                    if (user_data.Count > 0)
                        MessageBox.Show("Неправильный пароль");
                    else
                        MessageBox.Show("Вы не зарегистрированы");
                }
            }
            //Выход
            else
            {
                //Глобальные переменные
                Login = "";
                IsAdmin = false;

                //Компоненты на форме
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(LoginLabel);
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(PasswordLabel);
                AuthPanel.Controls.Add(PasswordTextBox);
                AuthPanel.Controls.Add(LoginButton);
                LoginButton.Text = "Вход";
            }

        }


        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.ShowDialog();

            HelloLabel.Text = "Привет, " + Login;
        }
    }
}
