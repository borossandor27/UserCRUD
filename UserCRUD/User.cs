using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD
{
    public partial class User
    {


        public User(string jsontext)
        {
            jsontext = jsontext.Trim('{', '}', ' ',',');
            string[] adatok= jsontext.Split(',');
            
            if (!long.TryParse(adatok[0].Split(':')[1].Trim(), out long id))
            {
                throw new FormatException("érvénytelen paraméter!");
            }
            this.id = id;
            this.nev = adatok[1].Split(':')[1].Trim();
            if (!long.TryParse(adatok[2].Split(':')[1].Trim(), out long fizetes)) { 
                throw new FormatException("érvénytelen fizetés érték!"); 
            }
            this.id = id;
            this.nev = nev;
            this.fizetes = fizetes;
        }

        public User(long id, string nev, long fizetes)
        {
            this.id = id;
            this.nev = nev;
            this.fizetes = fizetes;
        }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("nev")]
        public string nev { get; set; }

        [JsonProperty("fizetes")]
        public long fizetes { get; set; }


    }

}
