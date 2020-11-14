using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Profile
    {
        // Fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructors
        public Profile(string name, int age, string city = "Unknown", string country = "Unknown", string pronouns = "they/them")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new String[0];
        }

        // Properties
        private int Age
        {
            get { return this.age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("You must be at least 18 years old!");
                    Console.ReadLine();
                }
                else
                {
                    this.age = value;
                }
            }
        }

        // Methods
        public string ViewProfile()
        {
            string profileCard = $"Name: {this.name} \nAge: {this.Age} \nCity: {this.city} \nCountry: {this.country}";
            if (this.hobbies.Length > 0)
            {
                profileCard += " \nHobbies:";
                foreach (string hobby in this.hobbies)
                {
                    profileCard += $" {hobby} \n";
                }
            }
            
            return profileCard;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
