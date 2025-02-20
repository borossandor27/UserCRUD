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
            numericUpDownFizetes.Maximum = Decimal.MaxValue;
            await getUsers(); // Várakozunk az adatok betöltésére
            dataGridViewUsers.DataSource = users;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[index];
                textBoxid.Text = selectedRow.Cells["Id"].Value.ToString();
                textBoxNev.Text = selectedRow.Cells["Nev"].Value.ToString();
                numericUpDownFizetes.Value = Convert.ToDecimal(selectedRow.Cells["Fizetes"].Value);
            }
        }

        private async void buttonKuldes_Click(object sender, EventArgs e)
        {
            string nev = textBoxNev.Text;
            decimal fizetes = numericUpDownFizetes.Value;
            if (nev.Length == 0)
            {
                MessageBox.Show("Név megadása kötelező!");
                return;
            }
            var content = new StringContent($"{{\"nev\":\"{nev}\",\"fizetes\":{fizetes}}}", Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage result= await client.PostAsync(baseURL, content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres feltöltés!");
                    await getUsers();
                    dataGridViewUsers.DataSource = users;
                }
                else
                {
                    MessageBox.Show("Hiba a feltöltés során!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = textBoxid.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("Nincs kiválasztva felhasználó!");
                return;
            }
            if (MessageBox.Show("Biztosan törölni szeretné a felhasználót?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteUser(id);
            }
        }

        private async void deleteUser(string id)
        {
            try
            {
                HttpResponseMessage result = await client.DeleteAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    await getUsers();
                    dataGridViewUsers.DataSource = users;
                }
                else
                {
                    MessageBox.Show("Hiba a törlés során!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
