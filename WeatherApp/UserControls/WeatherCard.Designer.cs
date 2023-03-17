namespace WeatherApp.UserControls
{
    partial class WeatherCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbox_conditionIcon = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_dayCelsius = new System.Windows.Forms.Label();
            this.p_color = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_conditionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_conditionIcon
            // 
            this.pbox_conditionIcon.Location = new System.Drawing.Point(17, 41);
            this.pbox_conditionIcon.Name = "pbox_conditionIcon";
            this.pbox_conditionIcon.Size = new System.Drawing.Size(114, 67);
            this.pbox_conditionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_conditionIcon.TabIndex = 0;
            this.pbox_conditionIcon.TabStop = false;
            this.pbox_conditionIcon.MouseEnter += new System.EventHandler(this.WeatherCard_MouseEnter);
            this.pbox_conditionIcon.MouseLeave += new System.EventHandler(this.WeatherCard_MouseLeave);
            // 
            // lbl_date
            // 
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(0, 15);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(150, 23);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "lbl_date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_date.MouseEnter += new System.EventHandler(this.WeatherCard_MouseEnter);
            this.lbl_date.MouseLeave += new System.EventHandler(this.WeatherCard_MouseLeave);
            // 
            // lbl_dayCelsius
            // 
            this.lbl_dayCelsius.ForeColor = System.Drawing.Color.White;
            this.lbl_dayCelsius.Location = new System.Drawing.Point(3, 111);
            this.lbl_dayCelsius.Name = "lbl_dayCelsius";
            this.lbl_dayCelsius.Size = new System.Drawing.Size(147, 24);
            this.lbl_dayCelsius.TabIndex = 1;
            this.lbl_dayCelsius.Text = "lbl_dayCelsius";
            this.lbl_dayCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dayCelsius.MouseEnter += new System.EventHandler(this.WeatherCard_MouseEnter);
            this.lbl_dayCelsius.MouseLeave += new System.EventHandler(this.WeatherCard_MouseLeave);
            // 
            // p_color
            // 
            this.p_color.Location = new System.Drawing.Point(-7, 145);
            this.p_color.Margin = new System.Windows.Forms.Padding(0);
            this.p_color.Name = "p_color";
            this.p_color.Size = new System.Drawing.Size(166, 90);
            this.p_color.TabIndex = 2;
            this.p_color.MouseEnter += new System.EventHandler(this.WeatherCard_MouseEnter);
            this.p_color.MouseLeave += new System.EventHandler(this.WeatherCard_MouseLeave);
            // 
            // WeatherCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.p_color);
            this.Controls.Add(this.lbl_dayCelsius);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pbox_conditionIcon);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "WeatherCard";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.MouseEnter += new System.EventHandler(this.WeatherCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.WeatherCard_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_conditionIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_conditionIcon;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_dayCelsius;
        private System.Windows.Forms.Panel p_color;
    }
}
