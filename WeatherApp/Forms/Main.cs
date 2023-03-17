using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeatherApp.Classes;
using WeatherApp.Classes.Helpers;
using WeatherApp.UserControls;

namespace WeatherApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        WeatherApi weatherApi = new WeatherApi();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                return handleParam;
            }
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            FillWeatherSituationsFlowLayoutPanel("Ankara");
            FillTodayWeatherSituations("Ankara");
            FillCitiesFlowLayoutPanel();
        }

        #region Fill
        public void FillTodayWeatherSituations(string city)
        {
            Root root = weatherApi.GetWeatherForecast(city);

            pbox_conditionIcon.ImageLocation = "https:" + root.current.condition.icon;

            lbl_dayCelsius.Text = root.current.temp_c.ToString() + "°C";

            DateTime lastUpdated = DateTime.Parse(root.current.last_updated);
            lbl_todayDate.Text = lastUpdated.ToString("dddd, dd MMMM yyyy");

            lbl_conditionText.Text = root.current.condition.text;

            lbl_location.Text = root.location.name + ", " + root.location.country;

            lbl_windMph.Text = root.current.wind_mph.ToString() + "mph";
            lbl_windDir.Text = root.current.wind_dir.ToUpper();

            lbl_humidity.Text = root.current.humidity.ToString() + "%";

            lbl_visMiles.Text = root.current.vis_miles.ToString() + "miles";

            lbl_pressureMb.Text = root.current.pressure_mb.ToString() + "mb";

            int pbWIDTH = pictureBox1.Width;
            int pbHEIGHT = pictureBox1.Height;
            double pbUnit = pbWIDTH / 100.0;
            Bitmap bmp = new Bitmap(pbWIDTH, pbHEIGHT);
            int pbComplete = root.current.humidity;
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT));
            pictureBox1.Image = bmp;
        }

        public void FillWeatherSituationsFlowLayoutPanel(string city)
        {
            Root root = weatherApi.GetWeatherForecast(city);
            root.forecast.forecastday.RemoveAt(0);

            flp_weatherSituations.Controls.Clear();
            foreach (var forecastday in root.forecast.forecastday)
            {
                WeatherCard weatherCard = new WeatherCard();

                DateTime date = DateTime.Parse(forecastday.date);
                weatherCard.Date = date.ToString("dddd, dd MMMM yyyy");
                weatherCard.DayCelsius = forecastday.day.avgtemp_c.ToString();
                weatherCard.ConditionIconUrl = forecastday.day.condition.icon;

                flp_weatherSituations.Controls.Add(weatherCard);
            }
        }

        public void FillCitiesFlowLayoutPanel()
        {
            flp_cities.Controls.Clear();
            foreach (var city in weatherApi.GetCities())
            {
                Cities cities = new Cities();

                cities.City = city.Name;

                #region Event
                cities.Click += new EventHandler(Cities_Click);
                cities._cityClick += new EventHandler(Cities_Click);
                #endregion

                flp_cities.Controls.Add(cities);
            }
        }

        private void Cities_Click(object sender, EventArgs e)
        {
            Cities cities = sender as Cities;

            FillWeatherSituationsFlowLayoutPanel(cities.City);
            FillTodayWeatherSituations(cities.City);

            tlp.ColumnStyles[0].Width = 220;
            tlp.ColumnStyles[1].Width = 83;
            splitContainer1.Panel1Collapsed = true;
            txt_search.Clear();
        }
        #endregion

        #region Form
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 220;
        }
        #endregion

        #region Search
        private void btn_close_Click(object sender, EventArgs e)
        {
            tlp.ColumnStyles[0].Width = 220;
            tlp.ColumnStyles[1].Width = 83;
            splitContainer1.Panel1Collapsed = true;
            txt_search.Clear();
        }

        private void btn_searchForPlaces_Click(object sender, EventArgs e)
        {
            tlp.ColumnStyles[0].Width = 0f;
            tlp.ColumnStyles[1].Width = 100;
            splitContainer1.Panel1Collapsed = false;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.ToLower();

            flp_cities.Controls.Clear();

            if (string.IsNullOrEmpty(search))
            {
                FillCitiesFlowLayoutPanel();
            }
            else
            {
                var result = weatherApi.GetCities().Where(x => x.Name.ToLower().Contains(search)).ToList();

                foreach (var city in result)
                {
                    Cities cities = new Cities();

                    cities.City = city.Name;

                    #region Event
                    cities.Click += new EventHandler(Cities_Click);
                    cities._cityClick += new EventHandler(Cities_Click);
                    #endregion

                    flp_cities.Controls.Add(cities);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.Focus();
        }
        #endregion
    }
}