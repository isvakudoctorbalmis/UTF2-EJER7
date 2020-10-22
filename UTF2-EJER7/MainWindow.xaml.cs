using System;
using System.Windows;
using System.Windows.Controls;



namespace UTF2_EJER7
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      


        private void pequeñoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontSize =Int32.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
