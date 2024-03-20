namespace CustomApp.Pages;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();

		BindingContext = CalculatorPageModel.Instance;
	}
}