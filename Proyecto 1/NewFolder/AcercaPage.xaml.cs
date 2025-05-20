namespace Proyecto_1.NewFolder;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}
    private void btnHome_Clicked(object sender, EventArgs e)
    {
        //falta la pagina AcercaPage
        Application.Current.MainPage = new Home();
    }
    private void btnMenu_Clicked(object sender, EventArgs e)
    {
        
        Application.Current.MainPage = new Menu();
    }
}