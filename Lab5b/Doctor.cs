/*
  Class: Doctor.cs
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
    class Doctor
    {

        public string Ordinal { get; set; }
        public string Actor { get; set; }
        public string Series { get; set; }
        public string Age { get; set; }
        public string Debut { get; set; }

        public Doctor(string ordinal, string actor, string series, string age, string debut)
        {
            Ordinal = ordinal;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
        }

        public override string ToString()
        {
            return $"{Ordinal} {Actor} {Series} {Age} {Debut}";
        }

    }
}
