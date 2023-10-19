using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUP.Model;

namespace SignUP.Service
{
    public class SignUpService : AllProp
    {
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? ComfirmPassword { get; set; }


        public SignUpService
        (
            int Id,
            string? FirstName,
            string? LastName,
            int Age,
            string ? Email,
            string? Password,
            string? ComfirmPassword

        )
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Email = Email;
            this.Password = Password;
            this.ComfirmPassword = ComfirmPassword;

        }


        public void SigUpMethod()
        {
            string path = "Baza.txt";
            bool res = File.Exists(path);
            //Bazza.txt mavjud bulmasas
            if (!res)
            {
                File.AppendAllText(path, Id + "\n" + FirstName + "\n" + LastName + "\n" +
                    Age + "\n" + Email + "\n" + Password + "\n" + ComfirmPassword + "\n");
                Console.WriteLine();
            }
            //Bazza.txt mavjud bulsa
            else if (res == true)
            {
                List<string> malumot = File.ReadAllLines(path).ToList();
                bool tekshir = false;
                for(int i = 0; i < malumot.Count;i++)
                {
                    //Bazza.txt ni ichida foydalanuvchi bulsa
                    if(this.FirstName == malumot[i] && this.Email == malumot[i + 3] && this.Password == malumot[i + 4])
                    {
                        tekshir = true;
                        Console.WriteLine("Bu foydalanuvchi mavjud");

                    }

                }
                //Bazza.txt ni ichida foydalanuvchi mavjud bulmasa
                if (!tekshir)
                {
                    malumot.Add(Id.ToString());
                    malumot.Add(this.FirstName);
                    malumot.Add(this.LastName); 
                    malumot.Add(this.Age.ToString());
                    malumot.Add(this.Email);
                    malumot.Add(this.Password);
                    malumot.Add(this.ComfirmPassword);

                }
            }
        }
    }
}
