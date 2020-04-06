using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    public class Persona
    {
        private string name;
        private string lastName;
        private string rut;
        private string birth;
        private string country;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Country { get => country; set => country = value; }

        public Persona(string name, string lastName,string rut,string birth,string country)
        {
            this.name = name;
            this.lastName = lastName;
            this.rut = rut;
            this.birth = birth;
            this.country = country;
        }
    }
}
