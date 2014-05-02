﻿using System;
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
        private string login;

        private Message m1;
        private Message m2;
        private Message m3;
        private Message m4;
        private Canal c1;
        private Canal c2;
        private Canal c3;

        private Dictionary<string, Canal> canaux;
        private void InitData()
        {

            m1 = new Message("admin", DateTime.Now, "message 1");
            m2 = new Message("moi", DateTime.Now.AddDays(-1), "message 2");
            m3 = new Message("toi", DateTime.Now.AddMonths(-1), "message 3");
            m4 = new Message("admin", DateTime.Now.AddDays(-10), "message 4");

            c1 = new Canal("canal public 1", true);
            c1.addMessage(m1);
            c1.addMessage(m2);
            c2 = new Canal("canal public 2", true);
            c2.addMessage(m2);
            c2.addMessage(m3);
            c3 = new Canal("canal prive 1", false);
            c3.addMessage(m1);
            c3.addMessage(m4);

            canaux = new Dictionary<string, Canal>();
            canaux.Add(c1.tag, c1);
            canaux.Add(c2.tag, c2);
            canaux.Add(c3.tag, c3);
        }

        public MainWindow() : this("")
        {}

        public MainWindow(string login)
        {
            this.login = login;
            InitializeComponent();
            InitData();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            if (login != "")
            {
                labelCoucou.Content = "Bienvenue, " + login + " !";
                buttonConnexion.Content = "Se déconnecter";
            }
            foreach (var c in canaux)
            {
                if (c.Value.isPublic || login != "")
                    ComboBoxCanaux.Items.Add(c.Key);
            }

        }

        private void refreshMessages(object sender, RoutedEventArgs e)
        {
            DataGridMessage.ItemsSource = canaux[ComboBoxCanaux.SelectedItem.ToString()].messages;
        }

        private void buttonConnexion_Click(object sender, RoutedEventArgs e)
        {
            if (login == "")
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
    }
}
