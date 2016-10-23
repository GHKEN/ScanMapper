using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanMapEditor.Entity
{
    // to 2byte, from 2byte
    class ScanMap
    {
        public byte[] From { get; set; }
        public byte[] To { get; set; }

        public byte[] ToArray()
        {
            return To.Concat(From).ToArray();
        }
    }
}
