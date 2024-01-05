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
    //Vytvoření LoginData pro nastavení objektu
    public class LoginData
    {
        public string login { get; set; }
        public string password { get; set; }
    }

    public class StaticLogin
    {
        //Funkce CreateLoginFile, jenž vytvoří soubor 
        public static void CreateLoginFile()
        {
            string filePath = "login.json";

            if (!File.Exists(filePath))
            {
                //Vytvoření dat, jenž chceme dát do login.json souboru
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
        //Funkce pro zkusení přihlášení
        //Metoda vrací zpátky Bool, jenž určí, zda zadané údaje  jsou stejné jako v souboru
        public static bool TryLoginFile(string username, string password)
        {
            string filePath = "login.json";

            //Zjištění zda soubor exituje
            if (File.Exists(filePath))
            {
                //Přečtení dat ze souboru
                string jsonData = File.ReadAllText(filePath);

                //Deserializace Dat
                LoginData savedLoginData = JsonConvert.DeserializeObject<LoginData>(jsonData);

                //Ověření platnosti
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
