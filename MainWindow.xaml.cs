using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;

namespace TTRPGhelper
{
    public partial class MainWindow : Window
    {
        private Character myCharacter;

        public MainWindow()
        {
            InitializeComponent();

            myCharacter = DataService.LoadCharacter();

            this.DataContext = myCharacter;
        }

        private void DarkMode_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Resources["AppBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F0F2F5"));
            this.Resources["AppForeground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1C1E21"));
            this.Resources["CardBackground"] = new SolidColorBrush(Colors.White);
            this.Resources["CardBorder"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E4E6EB"));
            this.Resources["AccentColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1877F2"));
            this.Resources["AbilityBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F9F9F9"));
            this.Resources["AbilityTitle"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2C3E50"));
        }

        private void DarkMode_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["AppBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#18191A"));
            this.Resources["AppForeground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E4E6EB"));
            this.Resources["CardBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#242526"));
            this.Resources["CardBorder"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A3B3C"));
            this.Resources["AccentColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4599FF"));
            this.Resources["AbilityBackground"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2D2D30"));
            this.Resources["AbilityTitle"] = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void applyPathway_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
             "Do you want to add these pathway stats ON TOP of your current stats?\n\n" +
             "Yes = Keep your current base stats and add the pathway bonuses.\n" +
             "No = Reset back to base human stats before applying.",
             "Apply Stats Options",
             MessageBoxButton.YesNoCancel,
             MessageBoxImage.Question);

            if (result == MessageBoxResult.Cancel)
            {
                return;
            }

            myCharacter.ApplyOnTop = (result == MessageBoxResult.Yes);

            myCharacter.ApplyPathwayStats();

            this.DataContext = null;
            this.DataContext = myCharacter;
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                myCharacter.ImagePath = openFileDialog.FileName;
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DataService.SaveCharacter(myCharacter);
            MessageBox.Show("Character auto-saved to default location!");
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";

            if (openFileDialog.ShowDialog() == true)
            {
                var importedChar = DataService.ImportCharacter(openFileDialog.FileName);
                if (importedChar != null)
                {
                    myCharacter = importedChar;
                    this.DataContext = null;
                    this.DataContext = myCharacter;
                    MessageBox.Show("Character imported successfully!");
                }
            }
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json";

            saveFileDialog.FileName = string.IsNullOrWhiteSpace(myCharacter.Name) ? "NewCharacter" : myCharacter.Name;

            if (saveFileDialog.ShowDialog() == true)
            {
                DataService.ExportCharacter(myCharacter, saveFileDialog.FileName);
                MessageBox.Show("Character exported successfully!");
            }
        }
    }
}