using System;
using Xamarin.Forms;
using galleries.ViewModels;
using galleries.Views;

namespace galleries
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var tabs = new TabbedPage ();

			tabs.Children.Add (new PinPage {Title = "Pins", Icon = "glyphish_07_map_marker.png"});
			tabs.Children.Add (new ListPage {Title = "List", Icon = "glyphish_74_location.png"});

			MainPage = tabs;
		}

		private static GalleryViewModel viewmodel;
		public static GalleryViewModel Viewmodel{
			get{
				if (viewmodel == null) {
					viewmodel = new GalleryViewModel ();
				}
				return viewmodel;
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

