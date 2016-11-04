using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

using Xamarin.Forms;

namespace lgroup
{
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage()
		{
			InitializeComponent();

			map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.5506388, -46.5759001),Distance.FromMiles(1)));
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
