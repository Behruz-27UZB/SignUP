using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUP.Model;

namespace SignUP.Service
{
    public class SignInService : AllProp
    {
        public void SignInMethod()
        {
            string path = "Baza.txt";
            bool res = File.Exists(path);
            if(res)
            {
                List<string> malumot = File.ReadAllLines(path).ToList();
                bool tekshir = false;
                for(int i = 0; i < malumot.Count; i++)
                {
                    if(FirstName == malumot[i] || Email == malumot[i + 3] && Password == malumot[4])
                    {
                        Console.WriteLine("Hush kelipsiz");
                        tekshir = true;

                    }
                }
            }
            else
            {
                Console.WriteLine("Baza hali shakillanmagan");
            }
        }
        
    }
}
