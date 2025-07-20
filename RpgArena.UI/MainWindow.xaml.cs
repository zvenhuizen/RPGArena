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

namespace RpgArena.UI
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new GameSelectionWindow(/*pass "continue" flag */);
            window.Show();
        }
        private void NewCampaignButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new CampaignWindow();
            window.Show();
        }

        private void CharactersButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new CharactersWindow();
            window.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new SettingsWindow();
            window.Show();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new HelpWindow();
            window.Show();
        }
    }
}