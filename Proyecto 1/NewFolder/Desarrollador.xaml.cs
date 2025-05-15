namespace Proyecto_1.NewFolder;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private void btnAcerca_Clicked(object sender, EventArgs e)

    {
        //falta la pagina AcercaPage
        Application.Current.MainPage = Home();
    }
}