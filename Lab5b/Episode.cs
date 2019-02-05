/*
  Class:  Episode.cs
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
    class Episode
    {

        public string Story { get; set;}
        public string Season { get; set;}
        public string Year { get; set;}
        public string Title { get; set;}

        public Episode(string story, string season, string year, string title)
        {
            Story = story;
            Season = season;
            Year = year;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Story} {Season} {Year} {Title}";
        }
    }
}
