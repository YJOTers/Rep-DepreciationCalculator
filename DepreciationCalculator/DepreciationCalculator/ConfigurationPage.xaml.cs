namespace DepreciationCalculator;

public partial class ConfigurationPage : ContentPage
{
    public ConfigurationPage()
	{
		InitializeComponent();
        switch (Preferences.Get("language", 1)) 
        {
            case 1: GetSpanish();
                break;
            case 2: GetEnglish();
                break;
            case 3: GetPortugues();
                break;
        }
    }

	private async void OnBtnEspanolClicked(object sender, EventArgs e)
	{
        bool action = await DisplayAlert(Languages.LanguageEs.daTittle, Languages.LanguageEs.daMessage, 
            Languages.LanguageEs.daBtnYes, Languages.LanguageEs.daBtnNo);
        if (action)
        {
            Preferences.Set("language", 1);
        }
        SemanticScreenReader.Announce(btnEspanol.Text);
    }

    private async void OnBtnInglesClicked(object sender, EventArgs e)
    {
        bool action = await DisplayAlert(Languages.LanguageEn.daTittle, Languages.LanguageEn.daMessage,
            Languages.LanguageEn.daBtnYes, Languages.LanguageEn.daBtnNo);
        if (action)
        {
            Preferences.Set("language", 2);
        }
        SemanticScreenReader.Announce(btnIngles.Text);
    }

    private async void OnBtnPortugesClicked(object sender, EventArgs e)
    {
        bool action = await DisplayAlert(Languages.LanguagePt.daTittle, Languages.LanguagePt.daMessage,
            Languages.LanguagePt.daBtnYes, Languages.LanguagePt.daBtnNo);
        if (action)
        {
            Preferences.Set("language", 3);
        }
        SemanticScreenReader.Announce(btnPortuges.Text);
    }

    private void OnBtnModoDeColorClicked(object sender, EventArgs e)
    {
        if (Application.Current.RequestedTheme == AppTheme.Light)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
            Preferences.Set("color", 0);
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
            Preferences.Set("color", 1);
        }
        SemanticScreenReader.Announce(btnModoDeColor.Text);
    }

    private void GetSpanish() {
        lb1page2.Text = Languages.LanguageEs.lb1page2;
        btnEspanol.Text = Languages.LanguageEs.btnEspanol;
        btnIngles.Text = Languages.LanguageEs.btnIngles;
        btnPortuges.Text = Languages.LanguageEs.btnPortuges;
        lb2page2.Text = Languages.LanguageEs.lb2page2;
        if (Preferences.Get("color", 1) == 1)
        {
            btnModoDeColor.Text = Languages.LanguageEs.btnModoDeColor1;
        }
        else
        {
            btnModoDeColor.Text = Languages.LanguageEs.btnModoDeColor2;
        }
    }

    private void GetEnglish() {
        lb1page2.Text = Languages.LanguageEn.lb1page2;
        btnEspanol.Text = Languages.LanguageEn.btnEspanol;
        btnIngles.Text = Languages.LanguageEn.btnIngles;
        btnPortuges.Text = Languages.LanguageEn.btnPortuges;
        lb2page2.Text = Languages.LanguageEn.lb2page2;
        if (Preferences.Get("color", 1) == 1)
        {
            btnModoDeColor.Text = Languages.LanguageEn.btnModoDeColor1;
        }
        else
        {
            btnModoDeColor.Text = Languages.LanguageEn.btnModoDeColor2;
        }
    }

    private void GetPortugues() {
        lb1page2.Text = Languages.LanguagePt.lb1page2;
        btnEspanol.Text = Languages.LanguagePt.btnEspanol;
        btnIngles.Text = Languages.LanguagePt.btnIngles;
        btnPortuges.Text = Languages.LanguagePt.btnPortuges;
        lb2page2.Text = Languages.LanguagePt.lb2page2;
        if (Preferences.Get("color", 1) == 1)
        {
            btnModoDeColor.Text = Languages.LanguagePt.btnModoDeColor1;
        }
        else
        {
            btnModoDeColor.Text = Languages.LanguagePt.btnModoDeColor2;
        }
    }
}