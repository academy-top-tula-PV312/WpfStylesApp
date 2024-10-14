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

namespace WpfStylesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Style btnGreenStyle = new Style();
            btnGreenStyle.Setters.Add(new Setter { Property = Control.FontFamilyProperty, 
                                                   Value = new FontFamily("Calibri") });
            btnGreenStyle.Setters.Add(new Setter
            {
                Property = Control.BackgroundProperty,
                Value = new SolidColorBrush(Colors.DarkGreen)
            });
            btnGreenStyle.Setters.Add(new Setter
            {
                Property = Control.ForegroundProperty,
                Value = new SolidColorBrush(Colors.White)
            });
            btnGreenStyle.Setters.Add(new Setter
            {
                Property = Control.MarginProperty,
                Value = new Thickness(10)
            });
            btnGreenStyle.Setters.Add(new Setter
            {
                Property = Control.PaddingProperty,
                Value = new Thickness(5)
            });
            btnGreenStyle.Setters.Add(new Setter
            {
                Property = Control.WidthProperty,
                Value = 200.0
            });

            this.Resources.Add("btnGreenStyle", btnGreenStyle);

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtTablo.Text = (sender as Button).Content.ToString();
        }
    }
}