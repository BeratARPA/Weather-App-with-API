using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp.UserControls
{
    public partial class Cities : UserControl
    {
        public Cities()
        {
            InitializeComponent();
        }

        #region Properties
        private string _city;

        #region EventHandler
        public EventHandler _cityClick;
        #endregion

        [Category("Custom Props")]
        public string City
        {
            get { return _city; }
            set { _city = value; lbl_city.Text = value; }
        }
        #endregion

        private void lbl_city_Click(object sender, EventArgs e)
        {
            if (this._cityClick != null)
                this._cityClick(this, e);
        }

        private void Cities_MouseEnter(object sender, EventArgs e)
        {
            p_color.BackColor = Color.FromArgb(0, 117, 255);
        }

        private void Cities_MouseLeave(object sender, EventArgs e)
        {
            p_color.BackColor = Color.FromArgb(30, 33, 58);
        }
    }
}
