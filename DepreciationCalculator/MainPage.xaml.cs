using Microsoft.Maui;

namespace DepreciationCalculator;

public partial class MainPage : ContentPage
{
	decimal valorInicial, vidaUtil, valorResidual, depreciacion;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnBtnCalcularClicked(object sender, EventArgs e)
	{
		valorInicial = decimal.Parse(inputValorInicial.Text);
		vidaUtil = decimal.Parse(inputVidaUtil.Text);
		valorResidual = Math.Round(valorInicial / vidaUtil, 2);
		depreciacion = Math.Round((valorInicial - valorResidual) / vidaUtil, 2);
		lbDepreciacion.Text = GetResultOnLanguage(valorInicial, depreciacion, valorResidual);
        SemanticScreenReader.Announce(btnCalcular.Text);
	}

	private String GetResultOnLanguage(decimal valorInicial, decimal depreciacion, decimal valorResidual) {
		string res = "";
        switch (Preferences.Get("language", 1))
		{
			case 1:
                res = $"La depreciación acumulada del activo fijo es de ${valorInicial - valorResidual}. " +
            $"Por tanto, tendrá que registrarse una depreciación por año de ${depreciacion} " +
            $"hasta alcanzar el valor residual de ${valorResidual}.";
                break;
			case 2:
                res = $"Accumulated depreciation of property, plant and equipment is ${valorInicial - valorResidual}. " +
            $"Therefore, a depreciation per year of ${depreciacion} per year will have to be recorded " +
            $"until the residual value of ${valorResidual}.";
                break;
            case 3:
                res = $"A depreciação acumulada dos activos fixos é de ${valorInicial - valorResidual}. " +
            $"Por conseguinte, terá de ser registada uma depreciação anual de ${depreciacion} por ano " +
            $"até ao valor residual de ${valorResidual}.";
                break;
        }
		return res;
    }
}

