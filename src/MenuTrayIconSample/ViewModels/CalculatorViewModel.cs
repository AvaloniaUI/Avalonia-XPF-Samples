using System.Globalization;
using System.Windows.Input;
using MenuTrayIconSample.Commands;

namespace MenuTrayIconSample.ViewModels;

/// <summary>
/// A simple and standard run-of-the-mill Calculator ViewModel.
/// </summary>
public sealed class CalculatorViewModel : ViewModelBase
{
    private string _display = "0";
    private double _firstNumber;
    private double _secondNumber;
    private string _operation;
    private bool _isNewCalculation = true;

    public string Display
    {
        get => _display;
        set
        {
            _display = value;
            OnPropertyChanged(nameof(Display));
        }
    }

    public ICommand NumberCommand { get; }
    public ICommand OperatorCommand { get; }
    public ICommand EqualsCommand { get; }
    public ICommand ClearCommand { get; }
    public ICommand ClearEntryCommand { get; }
    public ICommand DecimalCommand { get; }

    public CalculatorViewModel()
    {
        NumberCommand = new RelayCommand<string>(NumberInput);
        OperatorCommand = new RelayCommand<string>(OperatorInput);
        EqualsCommand = new RelayCommand(Calculate);
        ClearCommand = new RelayCommand(Clear);
        ClearEntryCommand = new RelayCommand(ClearEntry);
        DecimalCommand = new RelayCommand(AddDecimal);

        AppViewModel.Instance.ClearCommand = ClearCommand;
    }

    private void NumberInput(string number)
    {
        if (_isNewCalculation)
        {
            Display = number;
            _isNewCalculation = false;
        }
        else
        {
            Display += number;
        }
    }

    private void OperatorInput(string op)
    {
        _firstNumber = double.Parse(Display);
        _operation = op;
        _isNewCalculation = true;
    }

    private void Calculate()
    {
        _secondNumber = double.Parse(Display);
        double result = 0;

        switch (_operation)
        {
            case "+":
                result = _firstNumber + _secondNumber;
                break;
            case "-":
                result = _firstNumber - _secondNumber;
                break;
            case "*":
                result = _firstNumber * _secondNumber;
                break;
            case "/":
                if (_secondNumber != 0)
                    result = _firstNumber / _secondNumber;
                else
                    Display = "Error";
                break;
        }

        Display = result.ToString(CultureInfo.InvariantCulture);
        _isNewCalculation = true;
    }

    private void Clear()
    {
        Display = "0";
        _firstNumber = 0;
        _secondNumber = 0;
        _operation = null;
        _isNewCalculation = true;
    }

    private void ClearEntry()
    {
        Display = "0";
        _isNewCalculation = true;
    }

    private void AddDecimal()
    {
        if (!Display.Contains('.'))
            Display += ".";
    }
}