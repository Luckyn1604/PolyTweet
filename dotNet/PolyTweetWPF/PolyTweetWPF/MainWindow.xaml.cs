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

namespace PolyTweetWPF
{
    /// <summary>
    /// Logique d'interaction pour mainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UtilisateurManagerBeanService.UtilisateurManagerClient utilisateurManager;
        private CanalManagerBeanService.CanalManagerClient canalManager;
        private MessageManagerBeanService.MessageManagerClient messageManager;

        private string login;

        public MainWindow() : this("anonyme")
        {}

        public MainWindow(string login)
        {
            utilisateurManager = new UtilisateurManagerBeanService.UtilisateurManagerClient();
            canalManager = new CanalManagerBeanService.CanalManagerClient();
            messageManager = new MessageManagerBeanService.MessageManagerClient();

            this.login = login;
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            if (login != "anonyme")
            {
                labelCoucou.Content = "Bienvenue, " + login + " !";
                buttonConnexion.Content = "Se déconnecter";
                newCanalButton.Visibility = Visibility.Visible;
                newCanalIsPublic.Visibility = Visibility.Visible;
                newcanalLabel.Visibility = Visibility.Visible;
                newCanalTag.Visibility = Visibility.Visible;
                informationCreationCanal.Visibility = Visibility.Hidden;
                utilisateurManager.create(login);
                if (canalManager.afficherTagByAbonne(login) != null)
                    foreach (var c in canalManager.afficherTagByAbonne(login)) 
                        ComboBoxCanaux.Items.Add(c);
            }
            else
            {
                labelCoucou.Content = "Bienvenue, anonyme!";
                informationCreationCanal.Content = "Pour pouvoir créer un canal, vous devez tout d'abord vous connecter !";

                
            }

            if (canalManager.afficherTagByType("PUBLIC") != null)
                foreach (var c in canalManager.afficherTagByType("PUBLIC")) 
                    ComboBoxCanaux.Items.Add(c);
        }

        private void refreshMessages(object sender, RoutedEventArgs e)
        {
            String selection = ComboBoxCanaux.SelectedItem.ToString();
            List<Message> list = new List<Message>();
            if (messageManager.afficherIdByTag(selection) != null)
                foreach (var idMsg in messageManager.afficherIdByTag(selection))
                {
                    String auteur = messageManager.afficherAuteurByID(idMsg);
                    String date = messageManager.afficherDateByID(idMsg);
                    String texte = messageManager.afficherTexteByID(idMsg);
                    Message m = new Message(idMsg, auteur, date, texte);
                    list.Add(m);
                }
            DataGridMessage.ItemsSource = list;
        }

        private void buttonConnexion_Click(object sender, RoutedEventArgs e)
        {
            if (login == "anonyme")
            {
                LoginWindow loginWindow = new LoginWindow();
                this.Close();
                loginWindow.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }
        private void buttonCreerCanal_Click(object sender, RoutedEventArgs e)
        {
            string newTag = newCanalTag.Text; 
            if (!canalManager.canalExiste(newTag))
            {
                String newIsPublic;
                if (newCanalIsPublic.IsChecked.Value && newCanalIsPublic.IsChecked.HasValue)
                    newIsPublic = "PUBLIC";
                else
                    newIsPublic = "PRIVE";
                canalManager.creer(newTag, newIsPublic, login);
                ComboBoxCanaux.Items.Add(newTag);
                ResultCreationCanal.Content = "Canal créé avec succès !";
            }
            else
            {
                ResultCreationCanal.Content = "Ce tag est déjà utilisé !";
            }
        }
        private void buttonNewMessage_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxCanaux.SelectedValue != null)
            {
                messageManager.create(newMessageBox.Text, ComboBoxCanaux.SelectedValue.ToString(), login);
                refreshMessages(sender, e);
            }
        }
    }
}
