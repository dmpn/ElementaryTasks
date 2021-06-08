using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString.Model
{
    class NumbersClass
    {
        private const byte SHIFT_ON_UNICODE = 48;
        private StringBuilder name { get; set; }
        public StringBuilder text { get; set; }/* = new StringBuilder();*/

        public NumbersClass(int stage, string value)
        {
            //name = GetName (stage, value[value.Length-1]);
            text = GetStringNumber(stage, value).Append(name);
        }

        private StringBuilder GetStringNumber(int stage, string value)
        {
            int specialWords = 3;
            //int specialIndex = 2;
            StringBuilder resultText = new StringBuilder();
            int currentValue = 0;
            bool isZero;

            for (int i = 0; i < 3; i++)
            {
                if (!Char.IsDigit(value[i]))
                {
                    throw new ArgumentException ("Число введено неправильно");
                }

                currentValue = ( Convert.ToInt32 (value[i])) - SHIFT_ON_UNICODE;

                if (currentValue==0)
                {
                    isZero = true;
                }
                if (i == 1 && currentValue == 1)
                {
                    resultText.Append ( GetWord ( specialWords, (Convert.ToInt32(value[++i])) - SHIFT_ON_UNICODE ) );
                    resultText.Append(" ");
                    resultText.Append ( GetName ( stage, specialWords) );
                    return resultText;
                }
                resultText.Append ( GetWord(i, currentValue));
                resultText.Append ( " " );
            }
            resultText.Append ( GetName (stage, currentValue));
            return resultText;
        }


        private string GetWord ( int degree, int value )
        {
            return Words.numbers [degree] [value];
        }

        private StringBuilder GetName(int stage, int value)
        {
            StringBuilder name = new StringBuilder(Words.classes[stage]);
            int endingChoose;

            switch (Convert.ToInt32(value - SHIFT_ON_UNICODE))
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
            name.Append(" ");
            return name;
        }
    }
}
