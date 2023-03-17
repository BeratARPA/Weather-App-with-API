namespace WeatherApp.UserControls
{
    partial class Cities
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
            this.lbl_city = new System.Windows.Forms.Label();
            this.p_color = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(18, 15);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(56, 20);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "lbl_city";
            this.lbl_city.Click += new System.EventHandler(this.lbl_city_Click);
            this.lbl_city.MouseEnter += new System.EventHandler(this.Cities_MouseEnter);
            this.lbl_city.MouseLeave += new System.EventHandler(this.Cities_MouseLeave);
            // 
            // p_color
            // 
            this.p_color.Location = new System.Drawing.Point(-9, 44);
            this.p_color.Name = "p_color";
            this.p_color.Size = new System.Drawing.Size(202, 104);
            this.p_color.TabIndex = 1;
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.p_color);
            this.Controls.Add(this.lbl_city);
            this.Name = "Cities";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(169, 50);
            this.MouseEnter += new System.EventHandler(this.Cities_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Cities_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Panel p_color;
    }
}
