using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString.Model
{
    class NumbersClass
    {

        private StringBuilder name { get; set; }
        public StringBuilder text { get; set; } = new StringBuilder();

        public NumbersClass(int stage, string value)
        {
            this.name = GetName (stage, value[value.Length-1]);
            this.text = GetStringNumber(value).Append(name);
        }

        private StringBuilder GetStringNumber(string value)
        {
            StringBuilder tempString = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                tempString.Append(Words.numbers[i][Convert.ToInt32(value[i])-48]);
                tempString.Append(" ");
            }
            return tempString;
        }

        private StringBuilder GetName(int stage, char value)
        {
            StringBuilder name = new StringBuilder(Words.classes[stage]);
            int endingChoose;

            switch (Convert.ToInt32(value-48))
            {
                case 1:
                    endingChoose = 0;
                    break;
                case 2:
                case 3:
                case 4:
                    endingChoose = 1;
                    break;
                default:
                    endingChoose = 2;
                    break;
            }

            switch (stage)
            {
                case 0:
                    break;
                case 1:
                    name.Append(Words.ending[0][endingChoose]);
                    break;
                default:
                    name.Append(Words.ending[1][endingChoose]);
                    break;
            }
            
            return name;
        }
    }
}
