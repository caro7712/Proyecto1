using Proyecto_1.NewFolder;

namespace Proyecto_1.NewFolder;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        // L�gica para registrar
    }

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (passwordEntry.Text == "1234" && emailEntry.Text == "alumno")
        {
            Application.Current.MainPage = new Menu();
        }
        else
        {
            DisplayAlert("Error", "Contrase�a incorrecta", "Ok");
        }
    }
}