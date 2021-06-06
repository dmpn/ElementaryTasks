using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString.Model
{
    class NumbersClass
    {

        public string name { get; set; }
        public string result { get; set; }          

        public NumbersClass (string[][] numbers, string name, char[] value)
        {
            this.name = name;
            foreach ( char val in value)
            {

            }
        }
        
        public string GetString (char [] value)
        {
            return "";
        }
       
    }
}
