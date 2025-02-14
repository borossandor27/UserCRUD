using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCRUD
{

    public partial class Form1 : Form
    {
        string baseURL = "https://retoolapi.dev/MVwfIW/data";
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.ColumnCount = 3;
            dataGridViewUsers.Columns[0].Name = "Id";
            dataGridViewUsers.Columns[0].HeaderText = "Id";
            dataGridViewUsers.Columns[1].Name = "nev";
            dataGridViewUsers.Columns[1].HeaderText = "Név";
            dataGridViewUsers.Columns[2].Name = "Fizetés";
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.MultiSelect = false;

            getUsers();
            foreach (User user in users)
            {
                int index = dataGridViewUsers.Rows.Add();
                dataGridViewUsers.Rows[index].Cells[0].Value = user.Id;
                dataGridViewUsers.Rows[index].Cells[1].Value = user.Nev;
                dataGridViewUsers.Rows[index].Cells[2].Value = user.Fizetes;
            }
            
        }

        private async void getUsers()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(baseURL);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                users = User.FromJson(json); //-- A JSON szöveg alapján user példányokat készít és listába helyezi
            }
        }
    }
}
