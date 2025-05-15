namespace Proyecto_1.NewFolder;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}
    private void btnAcercaPage_Clicked(object sender, EventArgs e)

    {
        //falta la pagina AcercaPage
        Application.Current.MainPage = new Home();
    }
    private void btnAcercaPage_Clicked(object sender, EventArgs e)


    {
        
        Application.Current.MainPage = new Menu();
    }
}