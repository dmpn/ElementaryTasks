using Envelopes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes
{
    class Controller
    {
        float aSize { get; set; }
        float bSize { get; set; }
        float cSize { get; set; }
        float dSize { get; set; }
        Envelope envelope1;
        Envelope envelope2;
        public void Run (View view)
        {
            view.Start();
            do
            {
                aSize = view.EnterSides("Введите a: ");
                bSize = view.EnterSides("Введите b: ");
                cSize = view.EnterSides("Введите c: ");
                dSize = view.EnterSides("Введите d: ");
                envelope1 = new Envelope(aSize, bSize);
                envelope2 = new Envelope(cSize, dSize);               
            }
            while (view.PrintResult(envelope1.PutEnvelope(envelope2)));          
           
        }
        

    }
}
