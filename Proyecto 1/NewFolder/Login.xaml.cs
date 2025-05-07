using System.Runtime.InteropServices.ObjectiveC;

namespace Proyecto_1.NewFolder;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
}
private void btnRegistrar_Clicked (ObjectiveCTrackedTypeAttribute sender, EventArgs e)
{

}
private void btnIngresar_Clicked(ObjectiveCTrackedTypeAttribute sender, EventArgs e)
{
	if (passwordEntry.text=1234 && emailEntry.text=="alumno")

    {
		Application.Current.MainPage = new Menu7();

    }
	else
    {
		DisplayAlert("Error", "Contraseña incorrecta", "Ok");

    }
}