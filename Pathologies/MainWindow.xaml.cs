using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Data.SQLite;
using System.Windows.Input;
using System.Data;
using System.ComponentModel;
using System.Windows.Data;

namespace Pathologies
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPathologies pList;
        SqlLiteManager man = new SqlLiteManager();
        public MainWindow()
        {
            InitializeComponent();
            Maj();
        }



        public void Maj()
        {
            pList = new CPathologies();
            dataGrid.ItemsSource = pList;
            lb_nb_pat.Content = "Nombre de pathologie(s) enregistrée(s) : " + man.GetNbPathologies();
        }

        private void tb_recherche_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Pathologie p = o as Pathologie;
                    if (p != null)
                        return (p.nom.Contains(tb_recherche.Text));
                    return false;
                };
            }
        }

        private void but_ajouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutPathologieWindow aj = new AjoutPathologieWindow(this);
            aj.ShowDialog();
        }

        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex != -1)
            {
                Pathologie path = (Pathologie)dataGrid.SelectedItem;
                man.DeletePathologie(path);
                Maj();
            }
        }
    }
}
