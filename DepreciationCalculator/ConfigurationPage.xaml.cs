namespace DepreciationCalculator;

public partial class ConfigurationPage : ContentPage
{
    public ConfigurationPage()
	{
		InitializeComponent();
	}

	private void OnBtnEspanolClicked(object sender, EventArgs e)
	{
        Preferences.Set("language", 1);
        //Page 1
        MainPage ob = new MainPage();
        ob.lb1page1.Text = "CALCULE LA DEPRECIACIÓN DE SU ACTIVO FIJO";
        ob.lb2page1.Text = "DEPRECIACIÓN LINEAL";
        ob.inputValorInicial.Text = "Ingrese el valor inicial del activo";
        ob.inputVidaUtil.Text = "Ingrese la vida util en años del activo";
        ob.btnCalcular.Text = "CALCULAR";
        ob.lbDepreciacion.Text = "...";
        //Page 2
        lb1page2.Text = "Seleccione su idioma";
        btnEspanol.Text = "ESPAÑOL";
        btnIngles.Text = "INGLES";
        btnPortuges.Text = "PORTUGES";
        lb2page2.Text = "Cambiar modo de color";
        btnModoDeColor.Text = "OSCURO";
        SemanticScreenReader.Announce(btnEspanol.Text);
    }

    private void OnBtnInglesClicked(object sender, EventArgs e)
    {
        Preferences.Set("language", 2);
        //Page 1
        MainPage ob = new MainPage();
        ob.lb1page1.Text = "CALCULATE DEPRECIATION OF YOUR FIXED ASSETS";
        ob.lb2page1.Text = "LINEAR DEPRECIATION";
        ob.inputValorInicial.Text = "Enter the asset's initial value";
        ob.inputVidaUtil.Text = "Enter the asset's useful life in years";
        ob.btnCalcular.Text = "CALCULATE";
        ob.lbDepreciacion.Text = "...";
        //Page 2
        lb1page2.Text = "Select your language";
        btnEspanol.Text = "SPANISH";
        btnIngles.Text = "ENGLISH";
        btnPortuges.Text = "PORTUGUESE";
        lb2page2.Text = "Change color mode";
        btnModoDeColor.Text = "DARK";
        SemanticScreenReader.Announce(btnIngles.Text);
    }

    private void OnBtnPortugesClicked(object sender, EventArgs e)
    {
        Preferences.Set("language", 3);
        //Page 1
        MainPage ob = new MainPage();
        ob.lb1page1.Text = "CALCULAR A DEPRECIAÇÃO DOS SEUS ACTIVOS FIXOS";
        ob.lb2page1.Text = "AMORTIZAÇÃO LINEAR";
        ob.inputValorInicial.Text = "Introduzir o valor inicial do ativo";
        ob.inputVidaUtil.Text = "Indicar a vida útil em anos do ativo";
        ob.btnCalcular.Text = "CALCULAR";
        ob.lbDepreciacion.Text = "...";
        //Page 2
        lb1page2.Text = "Seleccione a sua língua";
        btnEspanol.Text = "ESPANHOL";
        btnIngles.Text = "INGLÊS";
        btnPortuges.Text = "PORTUGUÊS";
        lb2page2.Text = "Alterar o modo de cor";
        btnModoDeColor.Text = "ESCURO";
        SemanticScreenReader.Announce(btnPortuges.Text);
    }

    private void OnBtnModoDeColorClicked(object sender, EventArgs e)
    {
        if (Application.Current.RequestedTheme == AppTheme.Light){
            Application.Current.UserAppTheme = AppTheme.Dark;
            if (Preferences.Get("language", 1) == 1) {
                btnModoDeColor.Text = GetMode(2);
            }
            if (Preferences.Get("language", 1) == 2)
            {
                btnModoDeColor.Text = GetMode(4);
            }
            if (Preferences.Get("language", 1) == 3)
            {
                btnModoDeColor.Text = GetMode(6);
            }
        }
        else {
            Application.Current.UserAppTheme = AppTheme.Light;
            if (Preferences.Get("language", 1) == 1)
            {
                btnModoDeColor.Text = GetMode(1);
            }
            if (Preferences.Get("language", 1) == 2)
            {
                btnModoDeColor.Text = GetMode(3);
            }
            if (Preferences.Get("language", 1) == 3)
            {
                btnModoDeColor.Text = GetMode(5);
            }
        }
        SemanticScreenReader.Announce(btnModoDeColor.Text);
    }

    private String GetMode(short id) {
        string res = "";
        switch (id) {
            case 1:
                res = "OSCURO";
                break;
            case 2:
                res = "CLARO";
                break;
            case 3:
                res = "DARK";
                break;
            case 4:
                res = "LIGHT";
                break;
            case 5:
                res = "ESCURO";
                break;
            case 6:
                res = "CLARO";
                break;
        }
        return res;
    }
}