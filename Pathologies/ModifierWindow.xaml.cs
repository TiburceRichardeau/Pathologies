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
    /// Logique d'interaction pour ModifierWindow.xaml
    /// </summary>
    public partial class ModifierWindow : Window
    {
        Pathologie pathologie;
        SqlLiteManager manager = new SqlLiteManager();
        MainWindow mainWindow;

        public ModifierWindow(Pathologie p, MainWindow main)
        {
            InitializeComponent();
            this.mainWindow = main;
            this.pathologie = p;
            InitializeTb();
        }

        private void InitializeTb()
        {
            tb_app_alimentaire.Text = pathologie.approche_alimentaire;
            tb_autres_approches.Text = pathologie.autre_approche;
            tb_causes.Text = pathologie.causes;
            tb_complement_ali.Text = pathologie.complements_alimentaires;
            tb_pathologie.Text = pathologie.nom;
            tb_symptomes.Text = pathologie.symptomes;
        }

        private void but_modifier_Click(object sender, RoutedEventArgs e)
        {
            pathologie.nom = tb_pathologie.Text;
            pathologie.symptomes = tb_symptomes.Text;
            pathologie.approche_alimentaire = tb_app_alimentaire.Text;
            pathologie.autre_approche = tb_autres_approches.Text;
            pathologie.causes = tb_causes.Text;
            pathologie.complements_alimentaires = tb_complement_ali.Text;
            manager.ModifierPathologie(pathologie);
            MessageBox.Show("La modification & bien été prise en compte.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Maj();
        }
    }
}
