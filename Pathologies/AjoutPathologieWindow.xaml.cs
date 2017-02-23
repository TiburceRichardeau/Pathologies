using System.Windows;
using System.Windows.Input;

namespace Pathologies
{
    /// <summary>
    /// Logique d'interaction pour AjoutPathologieWindow.xaml
    /// </summary>
    public partial class AjoutPathologieWindow : Window
    {
        private MainWindow mainWindow;
        SqlLiteManager sqlM = new SqlLiteManager();

        public AjoutPathologieWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            tb_pathologie.Focus();
        }

        private void but_valider_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_pathologie.Text))
            {
                if(sqlM.AjouterPathologie(new Pathologie(tb_pathologie.Text, tb_causes.Text, tb_symptomes.Text, tb_app_alimentaire.Text, tb_complement_ali.Text, tb_autres_approches.Text)))
                {
                    //MessageBox.Show("La pathologie a été correctement ajouté.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                    mainWindow.Maj();
                    Close();
                }
                else
                    MessageBox.Show("Une erreur c'est produite.\nMerci de bien vouloir réessayer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
                but_valider_Click(sender, e);
        }
    }
}
