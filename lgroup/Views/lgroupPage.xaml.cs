using Xamarin.Forms;

namespace lgroup
{
	public partial class lgroupPage : ContentPage
	{
		public lgroupPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			btnAlerta.Text = "Cliquei";

			if(Device.OS == TargetPlatform.iOS)
				await DisplayAlert("Mensagem", "iOS " + txtNome.Text, "OK", "Cancel");
			else if (Device.OS == TargetPlatform.Android)
				await DisplayAlert("Mensagem", "Android " + txtNome.Text, "OK", "Cancel");
		}

		void fecharClick(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
