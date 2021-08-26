using MaterialDesignThemes.Wpf;
using System.Windows;

namespace PocDialogHost
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            OpenDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog();
        }

        private void OpenDialog()
        {
            DialogHost.Show(new TestControl(), "EcranPrincipalDialog");
        }
    }
}
