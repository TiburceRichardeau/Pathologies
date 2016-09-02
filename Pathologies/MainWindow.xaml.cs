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
        private RadioButton rb_ckecked = new RadioButton() ;

        public MainWindow()
        {
            InitializeComponent();
            Maj();
            rb_ckecked = rb_all;
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
                switch (rb_ckecked.Content.ToString())
                {
                    case "Toutes les colonnes":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.nom.Contains(tb_recherche.Text)) || p.symptomes.Contains(tb_recherche.Text) || (p.causes.Contains(tb_recherche.Text)) || (p.approche_alimentaire.Contains(tb_recherche.Text)) || (p.autre_approche.Contains(tb_recherche.Text)) || (p.complements_alimentaires.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Nom Pathologie":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.nom.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Causes":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.causes.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Symptômes":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.symptomes.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Approche Alimentaire":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.approche_alimentaire.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Compléments Alimentaires":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.complements_alimentaires.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    case "Autre Approche":
                        cv.Filter = o =>
                        {
                            Pathologie p = o as Pathologie;
                            if (p != null)
                                return (p.autre_approche.Contains(tb_recherche.Text));
                            return false;
                        };
                        break;

                    default:
                        break;
                } 
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

        private void rb_nom_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_cause_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_all_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_symptomes_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_app_alimentaire_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_compl_alimentaire_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }

        private void rb_autre_Checked(object sender, RoutedEventArgs e)
        {
            rb_ckecked = (RadioButton)sender;
        }
    }
}
