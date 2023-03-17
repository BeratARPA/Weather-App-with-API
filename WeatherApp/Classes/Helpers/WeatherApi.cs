using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp.Classes.Helpers
{
    public class WeatherApi
    {
        string _baseUrl = "https://api.weatherapi.com/v1/";
        string _apiKey = "ca2575b390c44363aea152040230403";

        public Root GetWeatherForecast(string city)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_baseUrl + "forecast.json?key=" + _apiKey + "&q=" + city + "&days=6");

                request.ContentType = "application/json";
                request.Method = "GET";

                using (var response = request.GetResponse())
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    Root root = JsonExtensions.ToObject<Root>(streamReader.ReadToEnd());

                    return root;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
      
        public List<City> GetCities()
        {
            List<City> cities = new List<City>();

            City city1 = new City { Name = "Adana" };
            cities.Add(city1);

            City city2 = new City { Name = "Adiyaman" };
            cities.Add(city2);

            City city3 = new City { Name = "Afyonkarahisar" };
            cities.Add(city3);

            City city4 = new City { Name = "Agri" };
            cities.Add(city4);

            City city5 = new City { Name = "Amasya" };
            cities.Add(city5);

            City city6 = new City { Name = "Ankara" };
            cities.Add(city6);

            City city7 = new City { Name = "Antalya" };
            cities.Add(city7);

            City city8 = new City { Name = "Artvin" };
            cities.Add(city8);

            City city9 = new City { Name = "Aydin" };
            cities.Add(city9);

            City city10 = new City { Name = "Balikesir" };
            cities.Add(city10);

            City city11 = new City { Name = "Bilecik" };
            cities.Add(city11);

            City city12 = new City { Name = "Bingol" };
            cities.Add(city12);

            City city13 = new City { Name = "Bitlis" };
            cities.Add(city13);

            City city14 = new City { Name = "Bolu" };
            cities.Add(city14);

            City city15 = new City { Name = "Burdur" };
            cities.Add(city15);

            City city16 = new City { Name = "Bursa" };
            cities.Add(city16);

            City city17 = new City { Name = "Canakkale" };
            cities.Add(city17);

            City city18 = new City { Name = "Cankiri" };
            cities.Add(city18);

            City city19 = new City { Name = "Corum" };
            cities.Add(city19);

            City city20 = new City { Name = "Denizli" };
            cities.Add(city20);

            City city21 = new City { Name = "Diyarbakir" };
            cities.Add(city21);

            City city22 = new City { Name = "Edirne" };
            cities.Add(city22);

            City city23 = new City { Name = "Elazig" };
            cities.Add(city23);

            City city24 = new City { Name = "Erzincan" };
            cities.Add(city24);

            City city25 = new City { Name = "Erzurum" };
            cities.Add(city25);

            City city26 = new City { Name = "Eskisehir" };
            cities.Add(city26);

            City city27 = new City { Name = "Gaziantep" };
            cities.Add(city27);

            City city28 = new City { Name = "Giresun" };
            cities.Add(city28);

            City city29 = new City { Name = "Gumushane" };
            cities.Add(city29);

            City city30 = new City { Name = "Hakkari" };
            cities.Add(city30);

            City city31 = new City { Name = "Hatay" };
            cities.Add(city31);

            City city32 = new City { Name = "Isparta" };
            cities.Add(city32);

            City city33 = new City { Name = "Mersin" };
            cities.Add(city33);

            City city34 = new City { Name = "Istanbul" };
            cities.Add(city34);

            City city35 = new City { Name = "Izmir" };
            cities.Add(city35);

            City city36 = new City { Name = "Kars" };
            cities.Add(city36);

            City city37 = new City { Name = "Kastamonu" };
            cities.Add(city37);

            City city38 = new City { Name = "Kayseri" };
            cities.Add(city38);

            City city39 = new City { Name = "Kirklareli" };
            cities.Add(city39);

            City city40 = new City { Name = "Kirsehir" };
            cities.Add(city40);

            City city41 = new City { Name = "Kocaeli" };
            cities.Add(city41);

            City city42 = new City { Name = "Konya" };
            cities.Add(city42);

            City city43 = new City { Name = "Kutahya" };
            cities.Add(city43);

            City city44 = new City { Name = "Malatya" };
            cities.Add(city44);

            City city45 = new City { Name = "Manisa" };
            cities.Add(city45);

            City city46 = new City { Name = "Kahramanmaras" };
            cities.Add(city46);

            City city47 = new City { Name = "Mardin" };
            cities.Add(city47);

            City city48 = new City { Name = "Mugla" };
            cities.Add(city48);

            City city49 = new City { Name = "Mus" };
            cities.Add(city49);

            City city50 = new City { Name = "Nevsehir" };
            cities.Add(city50);

            City city51 = new City { Name = "Nigde" };
            cities.Add(city51);

            City city52 = new City { Name = "Ordu" };
            cities.Add(city52);

            City city53 = new City { Name = "Rize" };
            cities.Add(city53);

            City city54 = new City { Name = "Sakarya" };
            cities.Add(city54);

            City city55 = new City { Name = "Samsun" };
            cities.Add(city55);

            City city56 = new City { Name = "Siirt" };
            cities.Add(city56);

            City city57 = new City { Name = "Sinop" };
            cities.Add(city57);

            City city58 = new City { Name = "Sivas" };
            cities.Add(city58);

            City city59 = new City { Name = "Tekirdag" };
            cities.Add(city59);

            City city60 = new City { Name = "Tokat" };
            cities.Add(city60);

            City city61 = new City { Name = "Trabzon" };
            cities.Add(city61);

            City city62 = new City { Name = "Tunceli" };
            cities.Add(city62);

            City city63 = new City { Name = "Sanliurfa" };
            cities.Add(city63);

            City city64 = new City { Name = "Usak" };
            cities.Add(city64);

            City city65 = new City { Name = "Van" };
            cities.Add(city65);

            City city66 = new City { Name = "Yozgat" };
            cities.Add(city66);

            City city67 = new City { Name = "Zonguldak" };
            cities.Add(city67);

            City city68 = new City { Name = "Aksaray" };
            cities.Add(city68);

            City city69 = new City { Name = "Kırıkkale" };
            cities.Add(city69);

            City city70 = new City { Name = "Bayburt" };
            cities.Add(city70);

            City city71 = new City { Name = "Karaman" };
            cities.Add(city71);

            City city72 = new City { Name = "Kirikkale" };
            cities.Add(city72);

            City city73 = new City { Name = "Batman" };
            cities.Add(city73);

            City city74 = new City { Name = "Sirnak" };
            cities.Add(city74);

            City city75 = new City { Name = "Bartin" };
            cities.Add(city75);

            City city76 = new City { Name = "Ardahan" };
            cities.Add(city76);

            City city77 = new City { Name = "Igdir" };
            cities.Add(city77);

            City city78 = new City { Name = "Yalova" };
            cities.Add(city78);

            City city79 = new City { Name = "Karabuk" };
            cities.Add(city79);

            City city80 = new City { Name = "Kilis" };
            cities.Add(city80);

            City city81 = new City { Name = "Osmaniye" };
            cities.Add(city81);

            return cities.OrderBy(c => c.Name).ToList();
        }
    }
}