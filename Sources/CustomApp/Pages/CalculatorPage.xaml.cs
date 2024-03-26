using CustomApp.Models.Pages;

namespace CustomApp.Pages;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
        InitializeComponent();

		BindingContext = CalculatorPageModel.Instance;
	}

   
    private void OnNumberClicked(object sender, EventArgs e)
	{
		Button? button = sender as Button;

		if (CalculatorPageModel.Instance.Operation == string.Empty)
		{
			CalculatorPageModel.Instance.CurrentImput += button.Text;		
			resultDisplay.Text = CalculatorPageModel.Instance.CurrentImput;
			CalculatorPageModel.Instance.Number1 = double.Parse(CalculatorPageModel.Instance.CurrentImput);
		}
		else
		{
			CalculatorPageModel.Instance.CurrentImput += button.Text;
			resultDisplay.Text = CalculatorPageModel.Instance.Number1.ToString() + CalculatorPageModel.Instance.Operation + CalculatorPageModel.Instance.CurrentImput;
			CalculatorPageModel.Instance.Number2 = double.Parse(CalculatorPageModel.Instance.CurrentImput);
        }
    }

	private void OnOperatorClicked(object sender, EventArgs e)
	{
		Button? button = sender as Button;

		if (CalculatorPageModel.Instance.Operation == string.Empty)
		{
			CalculatorPageModel.Instance.Operation = button.Text;
			resultDisplay.Text += CalculatorPageModel.Instance.Operation;           
        } 
		else
		{
			CalculatorPageModel.Instance.Operation = string.Empty;
            CalculatorPageModel.Instance.Operation = button.Text;			
            resultDisplay.Text = CalculatorPageModel.Instance.Number1.ToString() + CalculatorPageModel.Instance.Operation + CalculatorPageModel.Instance.CurrentImput;
        }
		CalculatorPageModel.Instance.CurrentImput = string.Empty;
        
    }

	private void OnEqualClicked(object sender, EventArgs e)
	{
		switch(CalculatorPageModel.Instance.Operation)
            {
            case "+":
                CalculatorPageModel.Instance.Result = CalculatorPageModel.Instance.Number1 + CalculatorPageModel.Instance.Number2;
                break;
            case "-":
                CalculatorPageModel.Instance.Result = CalculatorPageModel.Instance.Number1 - CalculatorPageModel.Instance.Number2;
                break;
            case "*":
                CalculatorPageModel.Instance.Result = CalculatorPageModel.Instance.Number1 * CalculatorPageModel.Instance.Number2;
                break;
            case "/":
                if (CalculatorPageModel.Instance.Number2 != 0)
                    CalculatorPageModel.Instance.Result = CalculatorPageModel.Instance.Number1 / CalculatorPageModel.Instance.Number2;
                else
                    resultDisplay.Text = "Error! Error!";
                break;
            }
		CalculatorPageModel.Instance.Operation = string.Empty;
		CalculatorPageModel.Instance.CurrentImput = string.Empty;
		CalculatorPageModel.Instance.Number1 = CalculatorPageModel.Instance.Result;
		
        }

	private void OnClearClicked(object sender, EventArgs e)
	{
		CalculatorPageModel.Instance.Operation = string.Empty;
        CalculatorPageModel.Instance.CurrentImput = string.Empty;
        CalculatorPageModel.Instance.Number2 = 0;
        CalculatorPageModel.Instance.Number1 = 0;
		CalculatorPageModel.Instance.Result = 0;
		resultDisplay.Text = "0";
    }
}