using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Acr.UserDialogs;

namespace lgroup
{
	public partial class MainPage : ContentPage
	{
		

		public MainPage()
		{
			InitializeComponent();
		}

		void AddClick(object sender, System.EventArgs e)
		{

			Navigation.PushModalAsync(new NavigationPage(new CadastroPage()));
			/// <summary>
			/// Exemplo de como navegar com uma page: PushAsync ,
			///  PushModalAsync, PopModalAsync, PopAsync
			/// </summary>
			//Navigation.PushModalAsync(new PageCriada());
		}
	}
}
