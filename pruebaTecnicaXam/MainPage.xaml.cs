using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using pruebaTecnicaXam.LoginDir;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace pruebaTecnicaXam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            PutPins();
            var position = new Position(0, 0);
            mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(10000)));
        }

        void btnLogoutClick(object sender, EventArgs e)
        {
            App.Current.Logout();
        }

        void selectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Xamarin.Forms.Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                if((string)picker.ItemsSource[selectedIndex] == "Spain")
                {
                    carouselImages.ItemsSource = new List<ImageClass>()
                    {
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.spain1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.spain2.jpg")
                        }
                    };

                    var position = new Position(40.0000000, -4.0000000); // Latitude, Longitude
                    mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(400)));
                }
                else if ((string)picker.ItemsSource[selectedIndex] == "France")
                {
                    carouselImages.ItemsSource = new List<ImageClass>()
                    {
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.france1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.france2.jpg")
                        }
                    };

                    var position = new Position(46.0000000, 2.0000000); // Latitude, Longitude
                    mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(400)));
                }
                else if ((string)picker.ItemsSource[selectedIndex] == "UK")
                {
                    carouselImages.ItemsSource = new List<ImageClass>()
                    {
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.uk1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.uk2.jpg")
                        }
                    };
                    var position = new Position(54.0000000, -2.0000000);
                    mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(400)));
                }
                else if ((string)picker.ItemsSource[selectedIndex] == "Alls")
                {
                    carouselImages.ItemsSource = new List<ImageClass>()
                    {
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.spain1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.spain2.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.france1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.france2.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.uk1.jpg")
                        },
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromResource("pruebaTecnicaXam.Resources.uk2.jpg")
                        }
                    };
                    var position = new Position(0, 0);
                    mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(10000)));
                }
                else if ((string)picker.ItemsSource[selectedIndex] == "Random")
                {
                    Uri uri = new Uri("https://source.unsplash.com/random");
                    carouselImages.ItemsSource = new List<ImageClass>()
                    {
                        new ImageClass
                        {
                            ImgSource = ImageSource.FromUri(uri)
                        },
                    };
                    var position = new Position(0, 0);
                    mapCountry.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(10000)));
                }
            }
        }

        void PutPins()
        {
            var positionSp = new Position(40.0000000, -4.0000000); // Latitude, Longitude

            var pinSp = new Pin
            {
                Type = PinType.Place,
                Position = positionSp,
                Label = "País",
                Address = "España"
            };
            mapCountry.Pins.Add(pinSp);

            var positionFr = new Position(46.0000000, 2.0000000); // Latitude, Longitude

            var pinFr = new Pin
            {
                Type = PinType.Place,
                Position = positionFr,
                Label = "País",
                Address = "Francia"
            };
            mapCountry.Pins.Add(pinFr);

            var positionUk = new Position(54.0000000, -2.0000000); // Latitude, Longitude

            var pinUk = new Pin
            {
                Type = PinType.Place,
                Position = positionUk,
                Label = "País",
                Address = "United Kingdom"
            };
            mapCountry.Pins.Add(pinUk);
        }
    }
}