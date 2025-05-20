namespace Proyecto_1.NewFolder;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private void btnHome_Clicked(object sender, EventArgs e)
    {
        
        Application.Current.MainPage = new AcercaPage();
    }
    private void btnMenu_Clicked(object sender, EventArgs e)
    {
        
        Application.Current.MainPage = new Menu();
    }
    
}