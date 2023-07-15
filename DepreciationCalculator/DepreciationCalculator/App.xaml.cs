namespace DepreciationCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		if (Preferences.Get("color", 1) == 0){
            Current.UserAppTheme = AppTheme.Dark;
        }
		else {
            Current.UserAppTheme = AppTheme.Light;
        }
        MainPage = new AppShell();
	}
}
