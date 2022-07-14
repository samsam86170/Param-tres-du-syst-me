using System;
using System.Management;
using Microsoft.Win32;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace Paramètres_du_système
{
    public partial class InformationsSys : Form
    {
        /// <summary>
        /// Projet permettant la récupération des paramètres du système d'exploitation
        /// </summary>
        public InformationsSys()
        {
            InitializeComponent();

            //Création d'un timer permettant les mises à jour en temps réel
            //On doit pour cela utiliser la classe DispatcherTimer
            DispatcherTimer timer = new DispatcherTimer();//Créer une instance de la classe
            timer.Interval = TimeSpan.FromSeconds(0.8);//Réfraichissement toutes les 0.8s
            timer.Tick += timer_Tick;
            timer.Start();//Enclenchement le chrono


            InformationsSysteme infoSystem = new InformationsSysteme();
            lblSysteme.Text = infoSystem.GetOsInfos("os");
            lblArch.Text = infoSystem.GetOsInfos("arch");
            lblProcesseur.Text = infoSystem.GetCpuInfos();
            lblGPU.Text = infoSystem.GetGpuInfos();
            

        }
        // Mise à jour des infos du CPU et de la température
        void timer_Tick(object sender, EventArgs e)
        {
            // Mise à jour des informations du CPU
            lblPourcentage.Text = MiseAjourCpuInfos();
            // Mise à jour de la température du CPU
           /* miseAjourTemperature();*/
        }

        public void miseAjourTemperature()
        {
            double temperature = 0;
            String instanceName = "";
            // Requête officielle permettant de récupérer la température
            ManagementObjectSearcher ObjectSearcher = new ManagementObjectSearcher(@"root\WMI", "select * from MSAcpi_ThermalZoneTemperature");
            // Dans les objets du managementObject on choisit de récolter uniquement la température
            foreach (ManagementObject objet in ObjectSearcher.Get())
            {
                temperature = Convert.ToDouble(objet["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
                instanceName = objet["InstanceName"].ToString();
            }
            lblDegre.Text = temperature + "C°";
        }


        // Mise à jour des informations du CPU
        public string MiseAjourCpuInfos()
        {
            PerformanceCounter cpuInfos = new PerformanceCounter();
            cpuInfos.CategoryName = "Processor";
            cpuInfos.CounterName = "% Processor Time";//Mesure le pourcentage d'utilisation du processeur
            cpuInfos.InstanceName = "_Total";

            dynamic valeurNulle = cpuInfos.NextValue(); // Renvoie toujours zéro
            System.Threading.Thread.Sleep(50); // Fait patienter le processeur 50ms
            dynamic valeur = cpuInfos.NextValue(); // Retourne le % d'utilisation du processeur
            decimal valeurArrondie = Convert.ToDecimal(valeur); // On convertit la variable pour n'avoir que 2 décimales
            valeurArrondie = Math.Round(valeurArrondie, 2);
            return valeurArrondie + " %";
        }


        public class InformationsSysteme
        {
            /// <summary>
            /// Récupération des informations du système d'exploitation
            /// </summary>
            /// <param name="parametreArecuperer"></param>
            /// <returns></returns>
            public string GetOsInfos(string parametreArecuperer)
            {
                ManagementObjectSearcher managementObjSearcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem"); // recupere les infos du systeme d'exploitation, sont stockées dans la variable (requete sql)
                foreach (ManagementObject objet in managementObjSearcher.Get()) //Recuperer un objet spécifique dans la variable précédente
                {
                    switch (parametreArecuperer)
                    {
                        case "os": //recupere le systeme d'exploitation
                            return objet["Caption"].ToString(); //Recupere le nom du SE dans le tableau
                        case "arch": // recupere l'architecture
                            return objet["OSArchitecture"].ToString();
                        case "osv": // recupere la version de l'os
                            return objet["CSDVersion"].ToString();
                    }
                }
                return "";
            }


            ///<summary>
            ///Récupération des informations du processeur
            /// </summary>
            public string GetCpuInfos()
            {
                //Documentation officielle sur internet pour acceder aux informations du processeur
                RegistryKey nomProcesseur = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);
                if (nomProcesseur != null)
                {
                    return nomProcesseur.GetValue("ProcessorNameString").ToString();
                } //Permet de s'assurer que le programme ne plante pas
                return ""; //Si absence de clé
            }

            ///<summary>
            ///Récupération des informations de la carte graphique
            /// </summary>
            public string GetGpuInfos()
            {
                using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController")) //Carte graphique
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        Console.WriteLine("Name = " + obj["Name"]);

                        return obj["Name"].ToString(); //Retourne la carte graphique de l'ordi

                    }
                }
                return "";
            }
        }
    }
}
