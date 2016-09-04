using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Data.SQLite;
using System.Windows.Media;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Data;
using GitHubUpdate;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Media.Imaging;
using NLog;
using System.Threading;

namespace Pathologies
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPathologies pList;
        UpdateChecker checker;
        SqlLiteManager man = new SqlLiteManager();
        private RadioButton rb_ckecked = new RadioButton() ;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
            Maj();
            rb_ckecked = rb_all;
            CheckUpdate();
        }

        /// <summary>
        /// Verifie si lelogiciel est à jours.
        /// </summary>
        private async void CheckUpdate()
        {
            try
            {
                checker = new UpdateChecker("antoine1003", "Pathologies"); // pseudo github, no^m projet.

                UpdateType update = await checker.CheckUpdate();

                if (update == UpdateType.None)
                {
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri("pack://application:,,,/Pathologies;component/img/green_circle.png");
                    logo.EndInit();
                    imj_maj.ToolTip = "L'application est à jours.";
                    imj_maj.Source = logo;
                    logger.Info("Vérification des mises à jours : l'application est à jours.");
                }
                else
                {
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri("pack://application:,,,/Pathologies;component/img/orange_circle.png");
                    logo.EndInit();
                    imj_maj.ToolTip = "L'application n'est pas à jours. Cliquez pour MAJ.";
                    imj_maj.Source = logo;
                    imj_maj.MouseEnter += new MouseEventHandler(img_not_maj_MouseEnter);
                    imj_maj.MouseLeave += new MouseEventHandler(img_not_maj_MouseLeave);
                    imj_maj.MouseLeftButtonDown += new MouseButtonEventHandler(img_not_maj_MouseClick);
                    logger.Info("Vérification des mises à jours : l'application n'est pas à jours.");

                }
            }
            catch (Exception e)
            {
                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri("pack://application:,,,/Pathologies;component/img/red_circle.png");
                logo.EndInit();
                imj_maj.ToolTip = "Une erreur c'est produite vérifiez votre connexion internet.";
                imj_maj.Source = logo;
                logger.Error(e);
            }
           
        }
        
        /// <summary>
        /// Met à jours la DG, le nb de pathologies et la version.
        /// </summary>
        public void Maj()
        {
            logger.Info("Mise à jours des informations datagrid, label, ...");
            pList = new CPathologies();
            dataGrid.ItemsSource = pList;
            lb_nb_pat.Content = "Nombre de pathologie(s) enregistrée(s) : " + man.GetNbPathologies();
            lb_version.Content = GetCurrentVersion();
        }

        /// <summary>
        /// Retourne la version du logiciel.
        /// </summary>
        /// <returns></returns>
        private string GetCurrentVersion()
        {
            var obj = Assembly.GetExecutingAssembly().GetName().Version;
            string version = string.Format("v{0}.{1}.{2}", obj.Major, obj.Minor, obj.Build);
            return version;
        }

        // **************EVENTS********************


        private void img_not_maj_MouseClick(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Une mise a jour est disponible.\nVoulez-vous la télécharger?", "Mise à jours", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                checker.DownloadAsset("Pathologies.exe"); // opens it in the user's browser
            }
        }

        private void img_not_maj_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void img_not_maj_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
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

        //*** CONTEXT MENU ***
        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex != -1)
            {
                Pathologie path = (Pathologie)dataGrid.SelectedItem;
                man.DeletePathologie(path);
                Maj();
            }
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex != -1)
            {
                Pathologie path = (Pathologie)dataGrid.SelectedItem;
                ModifierWindow mo = new ModifierWindow(path, this);
                mo.ShowDialog();
            }
        }

        //*** RADIO BUTTONS ***

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

        //*** BUTTONS ***
        private void but_bug_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // here i wish set the parameters of email in this way 
                // 1. mailto = url;
                // 2. subject = txtSubject.Text;
                // 3. body = txtBody.Text;
                Process.Start("mailto:antoine.dautry@gmail.com?subject=[BUG] Pathologie " + GetCurrentVersion() + "&body=Merci de joindre le fichier log.txt dans le dossier du logiciel.");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
