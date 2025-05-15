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
   

    {
        
        Application.Current.MainPage = new Menu();
    }
}