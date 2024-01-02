using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;


namespace SemestralniPrace_JanHolda.Functions.Login
{
    public class LoginData
    {
        public string login { get; set; }
        public string password { get; set; }
    }

    public class StaticLogin
    {
        public static void CreateLoginFile()
        {
            string filePath = "login.json";

            if (!File.Exists(filePath))
            {
                LoginData loginData = new LoginData
                {
                    login = "Admin",
                    password = "Heslo"
                };

                // Serializace dat do JSON formátu pomocí Newtonsoft.Json
                string jsonData = JsonConvert.SerializeObject(loginData);

                // Zápis dat do souboru
                File.WriteAllText("login.json", jsonData);

                Console.WriteLine("Soubor byl vytvořen.");
            }
            else
            {
                Console.WriteLine("Soubor již existuje");
            }
        }
        public static bool TryLoginFile(string username, string password)
        {
            string filePath = "login.json";


            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                LoginData savedLoginData = JsonConvert.DeserializeObject<LoginData>(jsonData);

                if (username == savedLoginData.login && password == savedLoginData.password)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            
            }
            else 
            { 
                return false; 
            }
        }
       
    }
}
