using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp.Models.Pages
{
    class CalculatorPageModel : AbstractModel
    {
        public static readonly CalculatorPageModel Instance = new CalculatorPageModel();

        private CalculatorPageModel() {}

        private double? _number1 = 0;
        private double? _number2 = 0;
        private string? _operation = string.Empty;
        private string? _currentImput = string.Empty;
        private double? _result = 0;

        public string? Operation
        {
            set => SetProperty(ref _operation, value);
            get => _operation;

        }

        public double? Number1
        {
            set => SetProperty(ref _number1, value);
            get => _number1;
        }

        public double? Number2
        {
            set => SetProperty(ref _number2, value);
            get => _number2;
        }

        public string? CurrentImput
        {
            set => SetProperty(ref _currentImput, value);
            get => _currentImput;
        }

        public double? Result
        {
            set => SetProperty(ref _result, value);
            get => _result;
        }

       
           
        
    }
   
}
   

