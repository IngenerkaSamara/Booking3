namespace Booking3.UserControls
{
    partial class HotelsListUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.OptionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CapacityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.HotelsPanel = new System.Windows.Forms.Panel();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.SortComboBox);
            this.FilterPanel.Controls.Add(this.OptionsCheckedListBox);
            this.FilterPanel.Controls.Add(this.label5);
            this.FilterPanel.Controls.Add(this.CapacityComboBox);
            this.FilterPanel.Controls.Add(this.label4);
            this.FilterPanel.Controls.Add(this.RatingComboBox);
            this.FilterPanel.Controls.Add(this.label6);
            this.FilterPanel.Controls.Add(this.button1);
            this.FilterPanel.Controls.Add(this.dateTimePicker2);
            this.FilterPanel.Controls.Add(this.label3);
            this.FilterPanel.Controls.Add(this.FilterButton);
            this.FilterPanel.Controls.Add(this.dateTimePicker1);
            this.FilterPanel.Controls.Add(this.label2);
            this.FilterPanel.Controls.Add(this.label1);
            this.FilterPanel.Controls.Add(this.CityComboBox);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(684, 180);
            this.FilterPanel.TabIndex = 1;
            // 
            // SortComboBox
            // 
            this.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Дешевые выше",
            "Дорогие выше",
            "По рейтингу"});
            this.SortComboBox.Location = new System.Drawing.Point(554, 145);
            this.SortComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(126, 24);
            this.SortComboBox.TabIndex = 14;
            // 
            // OptionsCheckedListBox
            // 
            this.OptionsCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.OptionsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsCheckedListBox.FormattingEnabled = true;
            this.OptionsCheckedListBox.Items.AddRange(new object[] {
            "Отдельный номер",
            "Свой санузел",
            "Для некурящих",
            "Wi-Fi"});
            this.OptionsCheckedListBox.Location = new System.Drawing.Point(386, 45);
            this.OptionsCheckedListBox.Name = "OptionsCheckedListBox";
            this.OptionsCheckedListBox.Size = new System.Drawing.Size(162, 84);
            this.OptionsCheckedListBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Опции";
            // 
            // CapacityComboBox
            // 
            this.CapacityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapacityComboBox.FormattingEnabled = true;
            this.CapacityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CapacityComboBox.Location = new System.Drawing.Point(118, 78);
            this.CapacityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CapacityComboBox.Name = "CapacityComboBox";
            this.CapacityComboBox.Size = new System.Drawing.Size(173, 28);
            this.CapacityComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Человек";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingComboBox.Location = new System.Drawing.Point(386, 145);
            this.RatingComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(148, 24);
            this.RatingComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Рейтинг";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(554, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Filter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 148);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата выезда";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(0, 0);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(112, 35);
            this.FilterButton.TabIndex = 4;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 116);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Items.AddRange(new object[] {
            "Красноярск",
            "Ульяновск",
            "Хабаровск"});
            this.CityComboBox.Location = new System.Drawing.Point(118, 42);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(173, 28);
            this.CityComboBox.TabIndex = 0;
            // 
            // HotelsPanel
            // 
            this.HotelsPanel.AutoScroll = true;
            this.HotelsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HotelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelsPanel.Location = new System.Drawing.Point(0, 180);
            this.HotelsPanel.Name = "HotelsPanel";
            this.HotelsPanel.Size = new System.Drawing.Size(684, 209);
            this.HotelsPanel.TabIndex = 2;
            // 
            // HotelsListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HotelsPanel);
            this.Controls.Add(this.FilterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotelsListUC";
            this.Size = new System.Drawing.Size(684, 389);
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Panel HotelsPanel;
        private System.Windows.Forms.CheckedListBox OptionsCheckedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CapacityComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SortComboBox;
    }
}
