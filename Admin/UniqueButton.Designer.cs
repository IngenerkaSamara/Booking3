namespace Booking3.Admin
{
    partial class UniqueButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDeletePictureButton = new System.Windows.Forms.Button();
            this.ButtonLayoutCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonPictureButton = new System.Windows.Forms.Button();
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonFontButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ButtonDeletePictureButton
            // 
            this.ButtonDeletePictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonDeletePictureButton.Location = new System.Drawing.Point(365, 119);
            this.ButtonDeletePictureButton.Name = "ButtonDeletePictureButton";
            this.ButtonDeletePictureButton.Size = new System.Drawing.Size(71, 59);
            this.ButtonDeletePictureButton.TabIndex = 17;
            this.ButtonDeletePictureButton.Text = "X";
            this.ButtonDeletePictureButton.UseVisualStyleBackColor = true;
            // 
            // ButtonLayoutCombo
            // 
            this.ButtonLayoutCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonLayoutCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonLayoutCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonLayoutCombo.FormattingEnabled = true;
            this.ButtonLayoutCombo.Items.AddRange(new object[] {
            "Никакой",
            "Какой-то",
            "Во всю кнопку",
            "Во всю кнопку с пропорциями",
            "По центру"});
            this.ButtonLayoutCombo.Location = new System.Drawing.Point(143, 146);
            this.ButtonLayoutCombo.Name = "ButtonLayoutCombo";
            this.ButtonLayoutCombo.Size = new System.Drawing.Size(216, 32);
            this.ButtonLayoutCombo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(151, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Положение";
            // 
            // ButtonPictureButton
            // 
            this.ButtonPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonPictureButton.Location = new System.Drawing.Point(2, 119);
            this.ButtonPictureButton.Name = "ButtonPictureButton";
            this.ButtonPictureButton.Size = new System.Drawing.Size(128, 59);
            this.ButtonPictureButton.TabIndex = 14;
            this.ButtonPictureButton.Text = "Картинка";
            this.ButtonPictureButton.UseVisualStyleBackColor = true;
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonColorButton.Location = new System.Drawing.Point(2, 61);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(128, 52);
            this.ButtonColorButton.TabIndex = 13;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(347, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Образец";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(308, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonFontButton.Location = new System.Drawing.Point(2, 3);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(128, 52);
            this.ButtonFontButton.TabIndex = 10;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UniqueButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 193);
            this.Controls.Add(this.ButtonDeletePictureButton);
            this.Controls.Add(this.ButtonLayoutCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonPictureButton);
            this.Controls.Add(this.ButtonColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonFontButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniqueButton";
            this.Text = "Дизайн кнопки";
            this.Load += new System.EventHandler(this.UniqueButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeletePictureButton;
        private System.Windows.Forms.ComboBox ButtonLayoutCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonPictureButton;
        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}