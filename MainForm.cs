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
                        "SELECT DISTINCT name, id FROM room" +
                        " WHERE hotel_id='" + node2.Tag.ToString() + "' ORDER BY name");
                    for (int j = 0; j < rooms.Count; j += 2)
                    {
                        TreeNode node3 = new TreeNode(rooms[j]);
                        node3.Tag = rooms[j + 1];
                        node2.Nodes.Add(node3);
                    }
                }
            }

            Admin.AdminDesignForm.ApplyDesign(this);
            Admin.AdminDesignForm.BUTTON_CMS = contextMenuStrip1;
            Admin.AdminDesignForm.ApplyMenu(this);
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

                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Text = "Привет, " + Login;

                    AuthPanel.Controls.Add(LoginButton);
                    LoginButton.Text = "Выход";

                    AuthPanel.Controls.Add(AccountButton);
                    AuthPanel.Controls.Add(buttonDefaultDesign);
                    AccountButton.Visible = true;
                    Admin.AdminDesignForm.ApplyMenu(this);
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
                AuthPanel.Controls.Add(buttonDefaultDesign);
                LoginButton.Text = "Вход";
                Admin.AdminDesignForm.ApplyMenu(this);
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
                UserControls.HotelsListUC listUC = 
                    new UserControls.HotelsListUC(e.Node.Text);
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion

            #region Выбрана гостиница
            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Города")
            {
                UserControls.HotelUC listUC = new UserControls.HotelUC(e.Node.Tag.ToString());
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion

            #region Выбрана комната
            else if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Города")
            {
                UserControls.RoomUC listUC = new UserControls.RoomUC(e.Node.Tag.ToString());
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion

            #region Выбрана админка
            else if (e.Node.Level == 0 && e.Node.Text == "Админка")
            {
                Admin.AdminForm listUC = new Admin.AdminForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            else if (e.Node.Level == 1 &&
                e.Node.Parent.Text == "Админка" &&
                e.Node.Text == "Гостиницы")
            {
                Admin.AdminHotelsForm listUC = new Admin.AdminHotelsForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            else if (e.Node.Level == 1 &&
                e.Node.Parent.Text == "Админка" &&
                e.Node.Text == "Комнаты")
            {
                Admin.AdminRoomsForm listUC = new Admin.AdminRoomsForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            else if (e.Node.Level == 1 &&
                e.Node.Parent.Text == "Админка" &&
                e.Node.Text == "Бронирования")
            {
                Admin.AdminBookingForm listUC = new Admin.AdminBookingForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            else if (e.Node.Level == 1 &&
                e.Node.Parent.Text == "Админка" &&
                e.Node.Text == "Ошибки")
            {
                Admin.AdminLogForm listUC = new Admin.AdminLogForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            else if (e.Node.Level == 1 &&
                e.Node.Parent.Text == "Админка" &&
                e.Node.Text == "Пользователи")
            {
                Admin.AdminUsersForm listUC = new Admin.AdminUsersForm();
                listUC.Dock = DockStyle.Fill;
                HotelsPanel.Controls.Clear();
                HotelsPanel.Controls.Add(listUC);
            }
            #endregion

        }

        /// <summary>
        /// Скрытие админского узла
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsAdmin && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Админка");
                treeView1.Nodes.Add(node);

                TreeNode node2 = new TreeNode("Гостиницы");
                node.Nodes.Add(node2);
                TreeNode node3 = new TreeNode("Комнаты");
                node.Nodes.Add(node3);
                TreeNode node4 = new TreeNode("Пользователи");
                node.Nodes.Add(node4);
                TreeNode node5 = new TreeNode("Бронирования");
                node.Nodes.Add(node5);
                TreeNode node6 = new TreeNode("Ошибки");
                node.Nodes.Add(node6);
            }
            else if (!IsAdmin && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.AdminDesignForm af = new Admin.AdminDesignForm();
            af.ShowDialog();

            Admin.AdminDesignForm.ApplyDesign(this);
        }

        private void дизайнКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip cms = (ContextMenuStrip)(item.GetCurrentParent());
                Button btn = (Button)(cms.SourceControl);
                Admin.UniqueButton f = new Admin.UniqueButton(btn);
                f.ShowDialog();
            }
            catch (Exception) { }
        }
    }
}
