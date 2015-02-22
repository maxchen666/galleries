using System;
using Xamarin.Forms;

namespace galleries.Views
{
	public class ListPage: ContentPage
	{
		public ListPage ()
		{
			ListView list = new ListView () {
				ItemTemplate = new DataTemplate (typeof(GalleryItemCell)),
				ItemsSource = App.Viewmodel.galleries
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = { list }
			};

		}
	}
}

