using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanMapEditor.Entity
{
    class ScanMapSetting
    {
        public ScanMap[] ScanMaps { get; private set; }

        public ScanMapSetting(ScanMap[] scanMaps)
        {
            ScanMaps = scanMaps;
        }

        public byte[] ToArray()
        {
            var bytes = new List<byte>();
            var header = GetHeader();
            var body = GetBody();
            bytes.AddRange(header);
            bytes.AddRange(body);
            return bytes.ToArray();
        }

        public byte[] GetHeader()
        {
            byte[] header = new byte[12];
            header[8] = (byte)(ScanMaps.Count() + 1);
            return header;
        }

        public byte[] GetBody()
        {
            List<byte> bytes = new List<byte>();
            foreach(var scanMap in ScanMaps)
            {
                bytes.AddRange(scanMap.ToArray());
            }
            // nullで終端させる
            for (var i = 0; i < 4; i++)
            {
                bytes.Add(0);
            }
            return bytes.ToArray();
        }
    }
}
