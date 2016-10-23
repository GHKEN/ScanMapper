using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScanMapEditor;

namespace ScanMapEditor.Factory
{
    class ScanMap
    {
        public static Entity.ScanMap Create(byte[] rawScanMap)
        {
            var to = rawScanMap.Take(2).ToArray();
            var from = rawScanMap.Skip(2).Take(2).ToArray();
            return new Entity.ScanMap { From = from, To = to };
        } 
    }
}
