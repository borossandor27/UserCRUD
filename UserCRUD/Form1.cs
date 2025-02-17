using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCRUD
{

    public partial class Form1 : Form
    {
        readonly string baseURL = "https://retoolapi.dev/MVwfIW/data";
        private List<User> users = new List<User>();
        readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            await getUsers(); // Várakozunk az adatok betöltésére

            foreach (var item in users)
            {
                Console.WriteLine(item.nev);
            }
            dataGridViewUsers.DataSource = users;
            
            
        }

        private async Task getUsers()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseURL);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();

                    // Levágjuk a külső szögletes zárójeleket []
                    jsonString = jsonString.Trim('[', ']');

                    // eltávolítjuk a whitespace karaktereket és az idézőjeleket
                    jsonString = Regex.Replace(jsonString, @"\t|\n|\r|""", string.Empty);

                    int i = 0;
                    while (i < jsonString.Length)
                    {
                        // Egy {felhasználó adatai} szövege
                        string userText = "";
                        while (jsonString[i] != '}')
                        {
                            userText += jsonString[i];
                            i++;
                        }
                        userText += "}";
                        // A felhasználó adatainak szövege
                        User user = new User(userText.Trim());
                        users.Add(user);
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Hiba a lekérdezés során!");
                }
            }
            catch (HttpRequestException e)
            {

                MessageBox.Show(e.Message);
            }
            
        }
    }
}
