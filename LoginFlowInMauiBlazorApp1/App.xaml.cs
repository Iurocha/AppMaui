namespace LoginFlowInMauiBlazorApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Preferences.Set("FinappDarkmode", "1");

        MainPage = new MainPage();
	}
}
