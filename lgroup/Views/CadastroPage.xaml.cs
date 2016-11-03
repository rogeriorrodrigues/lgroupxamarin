using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lgroup
{
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
