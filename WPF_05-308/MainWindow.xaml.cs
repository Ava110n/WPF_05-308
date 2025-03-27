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
    public MainWindow()
    {
        InitializeComponent();
    }

    void onClick(object sender, RoutedEventArgs e)
    {
        //MessageBox.Show(sender.ToString().Split(" ")[1]);
        var text = (Button)sender;
        Calc.Text += text.Content.ToString();
    }
}