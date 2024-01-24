using Maui3d_1.Model;

namespace Maui3d_1.View;

public partial class CerchioPage : ContentPage
{
	public CerchioPage()
	{
		InitializeComponent();
	}

    private async void CalcolaAreaCerchio(object sender, EventArgs e)
    {
		Cerchio c = new Cerchio();
		c.Raggio=double.Parse(txtRaggio.Text);
		await App.Current.MainPage.DisplayAlert("Area Cerchio", c.AreaCerchio().ToString(), "OK");
        await App.Current.MainPage.DisplayAlert("Circonferenza", c.Circonferenza().ToString(), "OK");

    }
}