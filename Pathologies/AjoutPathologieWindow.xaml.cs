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
using System.Windows.Shapes;

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
        }

        private void but_valider_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_pathologie.Text))
            {
                if(sqlM.AjouterPathologie(new Pathologie(tb_pathologie.Text, tb_causes.Text, tb_symptomes.Text, tb_app_alimentaire.Text, tb_complement_ali.Text, tb_autres_approches.Text)))
                {
                    MessageBox.Show("La pathologie a été correctement ajouté.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                    mainWindow.Maj();
                    Close();
                }
                else
                    MessageBox.Show("Une erreur c'est produite.\nMerci de bien vouloir réessayer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
