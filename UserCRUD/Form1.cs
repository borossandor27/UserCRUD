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

            foreach (User item in users)
            {
                Console.WriteLine(item.Nev);
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

                    // JSON deszerializálás (helyes megoldás a JSON feldolgozására)
                    users = JsonConvert.DeserializeObject<List<User>>(jsonString);
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
