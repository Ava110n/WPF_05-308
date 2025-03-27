using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_05_308;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double x = 0;
    private double y = 0;
    private string z = "";

    public MainWindow()
    {
        InitializeComponent();
    }

    void onClickNumber(object sender, RoutedEventArgs e)
    {
        var btn = (Button)sender;
        var number = (string)btn.Content;

        Screen.Text += number;
        y = y * 10 + Convert.ToInt32(number);
    }
    void onClickSign(object sender, RoutedEventArgs e)
    {
        var btn = (Button)sender;
        var sign = (string)btn.Content;

        if (Screen.Text[Screen.Text.Length-1]=='+' || Screen.Text[Screen.Text.Length - 1] == '-' ||
            Screen.Text[Screen.Text.Length - 1] == '*' || Screen.Text[Screen.Text.Length - 1] == '/')
        {
            z = sign;
            Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1);
            Screen.Text += sign;
            return;
        }

        if (z == "")
        {
            x = y;
        }
        else
        {
            switch (z)
            {
                case "+": x = x + y; break;
                case "-": x = x - y; break;
                case "*": x = x * y; break;
                case "/": x = x / y; break;
            }
        }
        z = sign;
        y = 0;
        Screen.Text = x + z;
    }
}