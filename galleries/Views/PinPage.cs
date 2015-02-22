using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace galleries.Views
{
	public class PinPage: ContentPage
	{
		Map map;
		public PinPage ()
		{
			map = new Map { 
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};



			double centerlat = 0.0;
			double centerlong = 0.0;
			foreach (var item in App.Viewmodel.galleries) {
				var position = new Position(item.lat, item.lon); // Latitude, Longitude
				var pin = new Pin {
					Type = PinType.Place,
					Position = position,
					Label = item.suburb + "Gallery",
					Address = item.address
				};

				centerlat += item.lat;
				centerlong += item.lon;
				map.Pins.Add(pin);
			}
			centerlat = centerlat / App.Viewmodel.galleries.Count;
			centerlong = centerlong / App.Viewmodel.galleries.Count;
			map.MoveToRegion (MapSpan.FromCenterAndRadius (
				new Position (centerlat,centerlong), Distance.FromMiles (0.005)));

			Content = new StackLayout { 
				Spacing = 0,
				Children = {
					map
				}};

		}
	}
}

