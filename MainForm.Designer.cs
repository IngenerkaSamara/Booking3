namespace Booking3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Города");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.treeCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.treeDesignMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDefaultDesign = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.designCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.дизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.HotelsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.AuthPanel.SuspendLayout();
            this.treeCMS.SuspendLayout();
            this.designCMS.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.AccessibleDescription = "Block";
            this.AuthPanel.AutoScroll = true;
            this.AuthPanel.ContextMenuStrip = this.treeCMS;
            this.AuthPanel.Controls.Add(this.buttonDefaultDesign);
            this.AuthPanel.Controls.Add(this.PasswordLabel);
            this.AuthPanel.Controls.Add(this.LoginLabel);
            this.AuthPanel.Controls.Add(this.PasswordTextBox);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.LoginButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(948, 35);
            this.AuthPanel.TabIndex = 2;
            this.AuthPanel.Resize += new System.EventHandler(this.AuthPanel_Resize);
            // 
            // treeCMS
            // 
            this.treeCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeDesignMenuItem});
            this.treeCMS.Name = "contextMenuStrip1";
            this.treeCMS.Size = new System.Drawing.Size(151, 26);
            // 
            // treeDesignMenuItem
            // 
            this.treeDesignMenuItem.Name = "treeDesignMenuItem";
            this.treeDesignMenuItem.Size = new System.Drawing.Size(150, 22);
            this.treeDesignMenuItem.Text = "Дизайн блока";
            this.treeDesignMenuItem.Click += new System.EventHandler(this.treeDesignMenuItem_Click);
            // 
            // buttonDefaultDesign
            // 
            this.buttonDefaultDesign.Location = new System.Drawing.Point(544, 0);
            this.buttonDefaultDesign.Name = "buttonDefaultDesign";
            this.buttonDefaultDesign.Size = new System.Drawing.Size(82, 35);
            this.buttonDefaultDesign.TabIndex = 16;
            this.buttonDefaultDesign.Text = "Дизайн";
            this.buttonDefaultDesign.UseVisualStyleBackColor = true;
            this.buttonDefaultDesign.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(171, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 30);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 28);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 26);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginTextBox.Location = new System.Drawing.Point(65, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 26);
            this.LoginTextBox.TabIndex = 10;
            // 
            // LoginButton
            // 
            this.LoginButton.ContextMenuStrip = this.designCMS;
            this.LoginButton.Location = new System.Drawing.Point(350, 0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 31);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginClick);
            // 
            // designCMS
            // 
            this.designCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дизайнКнопкиToolStripMenuItem});
            this.designCMS.Name = "contextMenuStrip1";
            this.designCMS.Size = new System.Drawing.Size(158, 26);
            // 
            // дизайнКнопкиToolStripMenuItem
            // 
            this.дизайнКнопкиToolStripMenuItem.Name = "дизайнКнопкиToolStripMenuItem";
            this.дизайнКнопкиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.дизайнКнопкиToolStripMenuItem.Text = "Дизайн кнопки";
            this.дизайнКнопкиToolStripMenuItem.Click += new System.EventHandler(this.дизайнКнопкиToolStripMenuItem_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(171, 9);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(51, 20);
            this.HelloLabel.TabIndex = 14;
            this.HelloLabel.Text = "label6";
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(0, 2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(157, 33);
            this.AccountButton.TabIndex = 15;
            this.AccountButton.Text = "Личный кабинет";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Visible = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // HotelsPanel
            // 
            this.HotelsPanel.AutoScroll = true;
            this.HotelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelsPanel.Location = new System.Drawing.Point(253, 3);
            this.HotelsPanel.Name = "HotelsPanel";
            this.HotelsPanel.Size = new System.Drawing.Size(692, 415);
            this.HotelsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HotelsPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 421);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.AccessibleDescription = "Block";
            this.treeView1.ContextMenuStrip = this.treeCMS;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Города";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(244, 415);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CopyRightPanel
            // 
            this.CopyRightPanel.AccessibleDescription = "Block8";
            this.CopyRightPanel.AutoScroll = true;
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 456);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(948, 35);
            this.CopyRightPanel.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.CopyRightPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.treeCMS.ResumeLayout(false);
            this.designCMS.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Panel HotelsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDefaultDesign;
        private System.Windows.Forms.ContextMenuStrip designCMS;
        private System.Windows.Forms.ToolStripMenuItem дизайнКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip treeCMS;
        private System.Windows.Forms.ToolStripMenuItem treeDesignMenuItem;
        private System.Windows.Forms.Panel CopyRightPanel;
    }
}

