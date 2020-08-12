namespace Booking3.UserControls
{
    partial class SocialUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialUC));
            this.InstaPictureBox = new System.Windows.Forms.PictureBox();
            this.VKPictureBox = new System.Windows.Forms.PictureBox();
            this.SocialLabel = new System.Windows.Forms.Label();
            this.CopyRightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InstaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InstaPictureBox
            // 
            this.InstaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InstaPictureBox.Image")));
            this.InstaPictureBox.Location = new System.Drawing.Point(289, 0);
            this.InstaPictureBox.Name = "InstaPictureBox";
            this.InstaPictureBox.Size = new System.Drawing.Size(42, 35);
            this.InstaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InstaPictureBox.TabIndex = 3;
            this.InstaPictureBox.TabStop = false;
            this.InstaPictureBox.Click += new System.EventHandler(this.InstaPictureBox_Click);
            // 
            // VKPictureBox
            // 
            this.VKPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VKPictureBox.Image")));
            this.VKPictureBox.Location = new System.Drawing.Point(212, 0);
            this.VKPictureBox.Name = "VKPictureBox";
            this.VKPictureBox.Size = new System.Drawing.Size(35, 35);
            this.VKPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VKPictureBox.TabIndex = 2;
            this.VKPictureBox.TabStop = false;
            this.VKPictureBox.Click += new System.EventHandler(this.VKPictureBox_Click);
            // 
            // SocialLabel
            // 
            this.SocialLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SocialLabel.Location = new System.Drawing.Point(0, 0);
            this.SocialLabel.Name = "SocialLabel";
            this.SocialLabel.Size = new System.Drawing.Size(165, 39);
            this.SocialLabel.TabIndex = 1;
            this.SocialLabel.Text = "Наши соцсети";
            this.SocialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyRightLabel
            // 
            this.CopyRightLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CopyRightLabel.Location = new System.Drawing.Point(614, 0);
            this.CopyRightLabel.Name = "CopyRightLabel";
            this.CopyRightLabel.Size = new System.Drawing.Size(197, 39);
            this.CopyRightLabel.TabIndex = 0;
            this.CopyRightLabel.Text = "@Михаил Абрамов, 2020";
            this.CopyRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocialUC
            // 
            this.AccessibleDescription = "Block";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstaPictureBox);
            this.Controls.Add(this.VKPictureBox);
            this.Controls.Add(this.SocialLabel);
            this.Controls.Add(this.CopyRightLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SocialUC";
            this.Size = new System.Drawing.Size(811, 39);
            this.Load += new System.EventHandler(this.SocialUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SocialLabel;
        private System.Windows.Forms.Label CopyRightLabel;
        public System.Windows.Forms.PictureBox VKPictureBox;
        public System.Windows.Forms.PictureBox InstaPictureBox;
    }
}
