using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Random_numbers
{
    internal class Numbers
    {
        public int ID { get; set; }
        public string text { get; set; }
        public int number { get; set; }
        public bool found { get; set; }
        public string? type { get; set; }

        public string? date { get; set; }
        public string? year { get; set; }

        public override string ToString()
        {
            return $"Twoja liczba to: {this.number}: {this.text}";
        }

        //public Numbers(string? text, int number, bool found, string? type, string? date, string? year)
        //{
        //    this.text = text;
        //    this.number = number;
        //    this.found = found;
        //    this.type = type;
        //    this.date = date;
        //    this.year = year;
        //}
    }
}

