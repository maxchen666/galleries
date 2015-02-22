using System;
using System.ComponentModel;

namespace galleries.Models
{
	public class GalleryModel:INotifyPropertyChanged
	{
		public string address { get; set; }
		public string suburb { get; set; }
		public string postcode { get; set; }
		public string state { get; set; }
		public int id { get; set; }
		public double lat { get; set; }
		public double lon { get; set; }
		public int piecesofart { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public GalleryModel ()
		{
			address = "";
			suburb = "";
			postcode = "";
			state = "";
			id = 0;
			lat = 0.0;
			lon = 0.0;
			piecesofart = 0;
		}

		protected virtual void OnPropertyChanged(string name)
		{
			var ev = PropertyChanged;
			if (ev != null)
			{
				ev(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}

