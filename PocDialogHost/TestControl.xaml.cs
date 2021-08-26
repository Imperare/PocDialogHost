using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PocDialogHost
{
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();

            Loaded += Control_Loaded;
        }

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxWidth.Text = "1020";
            textBoxHeight.Text = "1080";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogHost.CloseDialogCommand.Execute(null, null);
        }

        private void TextBox_TextChangedWidth(object sender, TextChangedEventArgs e)
        {
            grid.Width = GetSize(textBoxWidth.Text);
        }

        private void TextBox_TextChangedHeight(object sender, TextChangedEventArgs e)
        {
            grid.Height = GetSize(textBoxHeight.Text);
        }

        private int GetSize(string number)
        {
            try
            {
                return Math.Max(500, int.Parse(number));
            }
            catch (Exception)
            {
                return 500;
            }
        }
    }
}
