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
                    "SELECT DISTINCT name, id FROM hotels" +
                    " WHERE city='" + node.Text + "' ORDER BY name");
                for (int i = 0; i < hotels.Count; i += 2)
                {
                    TreeNode node2 = new TreeNode(hotels[i]);
                    node2.Tag = hotels[i + 1];
                    node.Nodes.Add(node2);

                    List<string> rooms = SQLClass.Select(
                        "SELECT DISTINCT id, name FROM room" +
                        " WHERE hotel='" + node2.Text + "' ORDER BY name");
                    for (int j = 0; j < rooms.Count; j += 2)
                    {
                        TreeNode node3 = new TreeNode(rooms[j]);
                        node3.Tag = rooms[j + 1];
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

        /// <summary>
        /// Клик на дерево
        /// </summary>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region Выбран город
            if (e.Node.Level == 1 && e.Node.Parent.Text == "Города")
            {
                UserControls.HotelsListUC listUC = new UserControls.HotelsListUC();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);

                //e.Node.Text;
            }
            #endregion

            #region Выбрана гостиница
            if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Города")
            {
                UserControls.HotelUC listUC = new UserControls.HotelUC(e.Node.Tag.ToString());
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion

            #region Выбрана комната
            if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Города")
            {
                UserControls.RoomUC listUC = new UserControls.RoomUC(e.Node.Tag.ToString());
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion
        }
    }
}
