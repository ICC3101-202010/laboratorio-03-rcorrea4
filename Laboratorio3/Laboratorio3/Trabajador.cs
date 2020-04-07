﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    public class Trabajador : Persona
    {
        public string charge;
        public int salary;
        public string horario;

        public Trabajador(string name, string lastName, string rut, string birth, string country, string charge,int salary,string horario)
            :base(name,lastName,rut,birth,country)
        {
            this.charge = charge;
            this.salary = salary;
            this.horario = horario;
        }


    }
}
