using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Experiences.Forms
{
    public partial class GetLastVersionAsync : LABSForm
    {
        public GetLastVersionAsync()
        {
            InitializeComponent();
        }

        public static async Task<string> GetLastVersionAsyncMethod(string lastVersionFileLink)
        {
            string lastVersion = "";
            await Task.Run(() =>
            {
                if (!string.IsNullOrWhiteSpace(lastVersionFileLink)) // Vérification que la valeur n'est pas 'null' ou remplie d'espaces blancs.
                {
                    try
                    {
                        WebClient webClient = new WebClient(); // Création d'un nouveau WebClient
                        lastVersion = webClient.DownloadString(lastVersionFileLink); // Télécharge le texte de la page spécifiée et l'assigne à 'lastVersion'.
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message); // Affiche l'erreur qui s'est produite
                    }
                }
                else
                {
                    throw new ArgumentNullException("The parameter 'lastVersionFileLink' (string) is empty or contain only white spaces.");
                }
            });
            return lastVersion;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Task<string> task = GetLastVersionAsyncMethod("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Educ'Maths%204.0/Dev/Version.txt");
            string lastVersion = await task;
            MessageBox.Show(lastVersion);
            Debug.WriteLine("The last version is" + lastVersion);
        }
    }
}
