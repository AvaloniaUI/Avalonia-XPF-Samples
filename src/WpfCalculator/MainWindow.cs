// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AvaloniaUI.Xpf.WpfAbstractions;

namespace WpfCalculator
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : Window
    {
         private double _lastNumber, _result;
         private Operator _operator;

        public MainWindow()
        {
            InitializeComponent();

            // Functions buttons handlers
            buttonAllClear.Click += _buttonAllClear_Click;
            buttonNegative.Click += _buttonNegative_Click;
            buttonPercent.Click += _buttonPercent_Click;
            buttonEqual.Click += _buttonEqual_Click;

            // Numbers buttons handlers
            button0.Click += (sender, e) => _setNumber(0);
            button1.Click += (sender, e) => _setNumber(1);
            button2.Click += (sender, e) => _setNumber(2);
            button3.Click += (sender, e) => _setNumber(3);
            button4.Click += (sender, e) => _setNumber(4);
            button5.Click += (sender, e) => _setNumber(5);
            button6.Click += (sender, e) => _setNumber(6);
            button7.Click += (sender, e) => _setNumber(7);
            button8.Click += (sender, e) => _setNumber(8);
            button9.Click += (sender, e) => _setNumber(9);

            // Decimal button handler
            buttonDecimal.Click += (sender, e) => _setDecimal();
        }

        private void _setDecimal()
        {
            if (!labelResult.Content.ToString().Contains("."))
            {
                labelResult.Content = $"{labelResult.Content}.";
            }
        }

        private void _setNumber(int number)
        {
            if (labelResult.Content.ToString() == "0")
            {
                labelResult.Content = number.ToString();
            } 
            else
            {
                labelResult.Content = $"{labelResult.Content}{number}";
            }
        }

        private void _buttonOperation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(labelResult.Content.ToString(), out _lastNumber))
            {
                labelResult.Content = "0";
            }

            if (sender == buttonMultiply)
            {
                _operator = Operator.Multiplication;
            }
            else if (sender == buttonAdd)
            {
                _operator = Operator.Addition;
            }
            else if (sender == buttonDivide)
            {
                _operator = Operator.Division;
            }
            else if (sender == buttonSubtract)
            {
                _operator = Operator.Subtraction;
            }
        }

        private void _buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(labelResult.Content.ToString(), out double newNumber))
            {
                switch (_operator)
                {
                    case Operator.Addition:
                        _result = SimpleMath.Add(_lastNumber, newNumber);
                        break;
                    case Operator.Division:
                        _result = SimpleMath.Divide(_lastNumber, newNumber);
                        break;
                    case Operator.Multiplication:
                        _result = SimpleMath.Multiply(_lastNumber, newNumber);
                        break;
                    case Operator.Subtraction:
                        _result = SimpleMath.Subtract(_lastNumber, newNumber);
                        break;
                }

                labelResult.Content = _result.ToString();
            }
        }

        private void _buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;
            if (double.TryParse(labelResult.Content.ToString(), out tempNumber))
            {
                tempNumber /= 100;
                if (_lastNumber != 0)
                {
                    tempNumber *= _lastNumber;
                }

                labelResult.Content = $"{tempNumber}";
            }
        }

        private void _buttonNegative_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(labelResult.Content.ToString(), out _lastNumber))
            {
                _lastNumber *= -1;
                labelResult.Content = $"{_lastNumber}";
            }
        }

        private void _buttonAllClear_Click(object sender, RoutedEventArgs e)
        {
            _lastNumber = 0;
            _result = 0;
            labelResult.Content = $"{_lastNumber}";
        }
    }

    public enum Operator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                MessageBoxEx.ShowAsync("Division by 0 is not supported, obviously.", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }

            return n1 / n2;
        }
    }
}