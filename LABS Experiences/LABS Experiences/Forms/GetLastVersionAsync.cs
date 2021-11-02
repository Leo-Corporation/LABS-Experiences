/*
MIT License

Copyright (c) Léo Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
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
			string lastVersion;
			if (!string.IsNullOrWhiteSpace(lastVersionFileLink)) // Vérification que la valeur n'est pas 'null' ou remplie d'espaces blancs.
			{
				try
				{
					HttpClient httpClient = new();
					lastVersion = await httpClient.GetStringAsync(lastVersionFileLink); // Télécharge le texte de la page spécifiée et l'assigne à 'lastVersion'.
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

			return lastVersion;
		}

		public static Task<string> GetLastVerAsync(string link)
		{
			return new HttpClient().GetStringAsync(link);
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(await GetLastVerAsync("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/Educ'Maths%204.0/Dev/Version.txt"));
		}
	}
}
