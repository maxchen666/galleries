using System;
using Xamarin.Forms;

namespace galleries.Views
{
	public class GalleryItemCell : ViewCell
	{
		public GalleryItemCell ()
		{
			Label name = new Label () { Font = Font.SystemFontOfSize (12) };
			name.SetBinding(Label.TextProperty, new Binding(path: "suburb", stringFormat: "Name: {0} Gallery"));

			Label address = new Label () { Font = Font.SystemFontOfSize (12) };
			address.SetBinding(Label.TextProperty, "address");

			Label arts = new Label () { Font = Font.SystemFontOfSize (12) };
			arts.SetBinding(Label.TextProperty, new Binding(path: "piecesofart", stringFormat: "Arts: {0}"));

			Grid grid = new Grid () {
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
				},
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
				}
			};

			grid.Children.Add (name, 0, 2, 0, 1);
			grid.Children.Add (address, 0, 1, 1, 2);
			grid.Children.Add (arts, 1, 2, 1, 2);

			View = grid;
		}
	}
}

