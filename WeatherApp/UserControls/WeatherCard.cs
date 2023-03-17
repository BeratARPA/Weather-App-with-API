using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp.UserControls
{
    public partial class WeatherCard : UserControl
    {
        public WeatherCard()
        {
            InitializeComponent();
        }

        #region Properties
        private string _date;
        private string _dayCelsius;
        private string _conditionIconUrl;

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; lbl_date.Text = value; }
        }

        [Category("Custom Props")]
        public string DayCelsius
        {
            get { return _dayCelsius; }
            set { _dayCelsius = value; lbl_dayCelsius.Text = value + "°C"; }
        }

        [Category("Custom Props")]
        public string ConditionIconUrl
        {
            get { return _conditionIconUrl; }
            set { _conditionIconUrl = value; pbox_conditionIcon.ImageLocation = "https:" + value; }
        }
        #endregion

        #region Effect
        private void WeatherCard_MouseEnter(object sender, EventArgs e)
        {
            p_color.BackColor = Color.FromArgb(0, 117, 255);
        }

        private void WeatherCard_MouseLeave(object sender, EventArgs e)
        {
            p_color.BackColor = Color.FromArgb(30, 33, 58);
        }
        #endregion
    }
}
