using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JobApplicationsManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean state = false;
        private const String hiddenMessage = "HEHE, didn't expect this, did You?";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonClicked()
        {
            state = state ^ true;
            if (state)
            {
                this.hiddenLabel.Content = hiddenMessage;
            }
            else
            {
                this.hiddenLabel.Content = null;
            }
            
        }

        private void demoButton_Click(object sender, RoutedEventArgs e)
        {
            this.buttonClicked();
        }
    }
}
