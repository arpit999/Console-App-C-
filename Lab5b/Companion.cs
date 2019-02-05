/*
  Class:  Companion.cs
  Author: Arpit Patel
  Student ID: 000762465
  Date:   Decembner 7, 2018

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Companion
    {

        public string Name { get; set;}
        public string Actor { get; set;}
        public string Doctor { get; set;}
        public string Debut { get; set;}

        public Companion(string name, string actor, string doctor, string debut)
        {
            Name = name;
            Actor = actor;
            Doctor = doctor;
            Debut = debut;
        }

        public override string ToString()
        {
            return $"{Name} {Actor} {Doctor} {Debut}";
        }
    }
}
