
namespace Proyecto_1.NewFolder;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
    }
	private void btnAcerca_Clicked(object sender, EventArgs e)

	{
		//falta la pagina AcercaPage
		Application.Current.MainPage = new AcercaPage();
	}

    private void btnDesarrolladorClicked(object sender, EventArgs e)

    {
        //falta la pagina AcercaPage
        Application.Current.MainPage = new AcercaPage();
    }
    private void btnSalir_Clicked(object sender, EventArgs e)
    {
      #if ANDROID
    Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
      #elif WINDOWS
        System.Environment.Exit(0);
      #else
    Application.Current.Quit(); // iOS y otras (puede no cerrar realmente en iOS por políticas de Apple)
      #endif
    }

}

