using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopes.Model
{
    public struct Envelope
    {
        public float width { get; set; }
        public float height { get; set; }
        public int PutEnvelope (Envelope anotherEnvelope)
        {
            if (this.width < anotherEnvelope.width & this.height < anotherEnvelope.height)
                return 1;
            else if (this.width < anotherEnvelope.height & this.height < anotherEnvelope.width)
                return 1;
            else if (anotherEnvelope.width < this.width & anotherEnvelope.height < this.height)
                return 2;
            else if (anotherEnvelope.width < this.height & anotherEnvelope.height < this.width)
                return 2;
            return 0;
        }
        public Envelope (float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
