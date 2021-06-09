using System;
using System.Text;

namespace NumberToString.Model
{
    class Number
    {
        private const byte SHIFT_ON_UNICODE = 48;
        public StringBuilder stringValue { get;}
        public bool isZero = true;
        public Number(int stage, string value)
        {
            //name = GetName (stage, value[value.Length-1]);
            stringValue = GetStringNumber(stage, value);
        }
        private StringBuilder GetStringNumber(int stage, string value)
        {
            int specialWords = 3;
            int specialEndings = 5;
            //int specialIndex = 2;
            StringBuilder resultText = new StringBuilder();
            int currentValue = 0;
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                if (!Char.IsDigit(value[i]))
                {
                    throw new ArgumentException ("Число введено неправильно");
                }

                currentValue = ( Convert.ToInt32 (value[i])) - SHIFT_ON_UNICODE;
                sum += currentValue;
                if (i == 1 && currentValue == 1)
                {
                    resultText.Append (GetTextValue( specialWords, (Convert.ToInt32(value[++i])) - SHIFT_ON_UNICODE ) );
                    resultText.Append (" ");
                    resultText.Append ( GetClass( stage, specialEndings) );
                    return resultText;
                }
                resultText.Append (GetTextValue(i, currentValue));
                if (currentValue != 0)
                {
                    resultText.Append(" ");
                }
                
            }
            if (sum > 0)
            {
                resultText.Append(GetClass(stage, currentValue));
                isZero = false;
            }
            return resultText;
        }


        private string GetTextValue ( int degree, int value )
        {
            return Words.numbers [degree] [value];
        }

        private StringBuilder GetClass(int stage, int value)
        {
            StringBuilder name = new StringBuilder(Words.classes[stage]);
            int endingChoose;
            
            switch (value)
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

        public override string ToString ()
        {
            return stringValue.ToString();
        }
    }
    
}
