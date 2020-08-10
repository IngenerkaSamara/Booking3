namespace Booking3.Admin
{
    partial class TreeDesignForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveCoordsButton = new System.Windows.Forms.Button();
            this.CopyRightCLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(6, 34);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(148, 26);
            this.WidthTextBox.TabIndex = 1;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(7, 98);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(148, 26);
            this.HeightTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Высота";
            // 
            // SaveCoordsButton
            // 
            this.SaveCoordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SaveCoordsButton.Location = new System.Drawing.Point(7, 134);
            this.SaveCoordsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveCoordsButton.Name = "SaveCoordsButton";
            this.SaveCoordsButton.Size = new System.Drawing.Size(192, 80);
            this.SaveCoordsButton.TabIndex = 19;
            this.SaveCoordsButton.Text = "Сохранить";
            this.SaveCoordsButton.UseVisualStyleBackColor = true;
            this.SaveCoordsButton.Click += new System.EventHandler(this.SaveCoordsButton_Click);
            // 
            // CopyRightCLB
            // 
            this.CopyRightCLB.FormattingEnabled = true;
            this.CopyRightCLB.Items.AddRange(new object[] {
            "VK",
            "Insta"});
            this.CopyRightCLB.Location = new System.Drawing.Point(261, 34);
            this.CopyRightCLB.Name = "CopyRightCLB";
            this.CopyRightCLB.Size = new System.Drawing.Size(120, 88);
            this.CopyRightCLB.TabIndex = 20;
            // 
            // TreeDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 218);
            this.Controls.Add(this.CopyRightCLB);
            this.Controls.Add(this.SaveCoordsButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TreeDesignForm";
            this.Text = "Дизайн блока";
            this.Load += new System.EventHandler(this.TreeDesignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveCoordsButton;
        private System.Windows.Forms.CheckedListBox CopyRightCLB;
    }
}