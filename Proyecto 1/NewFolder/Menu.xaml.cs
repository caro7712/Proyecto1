namespace Proyecto_1.NewFolder;

public partial class Menu :ContentPage
{
	public Menu
	{
		InitializeComponent();
    }
	private void btnAcerca_Clicked.object sender, EventArgs e)

{
		Application.Current.MainPage = new AcercaPage ();
    }

