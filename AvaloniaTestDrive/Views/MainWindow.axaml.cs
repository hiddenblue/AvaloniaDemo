using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaTestDrive.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object sender, RoutedEventArgs args)
    {
        Console.WriteLine("Click!");
        Console.WriteLine($"Click! Celsius={Celsius.Text}");


        if (Double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
    
}