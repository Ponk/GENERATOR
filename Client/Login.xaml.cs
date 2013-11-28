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

namespace Client
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private System.Data.DataSet oDS;
        private WCF.CAM.CAM_Utilisateur oUtilisateur;


        public Login()
        {
            InitializeComponent();
            this.oDS = new System.Data.DataSet();
            this.oUtilisateur = new WCF.CAM.CAM_Utilisateur();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string login;
            string mdp;
            string token;
            string token_app = "rouen76";
            string tokenUtilisateur;

            this.oDS = this.oUtilisateur.CAM_selectUser("row", "jackr", "test");

            if (this.oDS.Tables[0].Rows.Count == 0)
            {
                MessageBoxResult m = MessageBox.Show("pas d'utilisateur trouvé");

            }
            else
            {
                tokenUtilisateur = this.oDS.Tables[0].Rows[0][0].ToString();
                login = this.oDS.Tables[0].Rows[0][1].ToString();
                mdp = this.oDS.Tables[0].Rows[0][2].ToString();
                token = this.oDS.Tables[0].Rows[0][3].ToString();

                if (token != token_app)
                {
                    MessageBoxResult m = MessageBox.Show("erreur token");
                }
                else
                {
                    MessageBoxResult m = MessageBox.Show(tokenUtilisateur);
                }

            }

            //connexion.generatePdf();

            //string mail = connexion.sendMail();



            /*MainWindow main = new MainWindow();
            this.Close();
            main.Show();*/
        }
    }
}