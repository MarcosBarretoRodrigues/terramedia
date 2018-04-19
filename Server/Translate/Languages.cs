using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Server.Translate
{
    class Languages
    {
        private int numero;
        

        public Languages()
        {
         
    
        }

        public string Translate(int codigo) {
            var json = System.IO.File.ReadAllText(@"Cliloc.json");
            string texto = "";
            var objects = JArray.Parse(json); // parse as array  
            foreach (JObject root in objects)
            {
                foreach (KeyValuePair<String, JToken> app in root)
                {
                    var appName = app.Key;
                    if (Convert.ToInt32(appName) == codigo)
                    {
                        texto = (String)app.Value["PT"];
                    }
                }
                   
                
            }

            return texto;
        }
    }
}
