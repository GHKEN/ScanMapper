using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanMapEditor.Factory
{
    class ScanMapSetting
    {
        public static Entity.ScanMapSetting CreateFromBytes(byte[] bytes)
        {
            var mapCount = bytes[8] - 1;
            Entity.ScanMap[] scanMaps = new Entity.ScanMap[mapCount];
            for (var i = 0; i < mapCount; i++)
            {
                scanMaps[i] = Factory.ScanMap.Create(bytes.Skip(12 + i * 4).Take(4).ToArray());
            }
            Entity.ScanMapSetting scanMapSetting = new Entity.ScanMapSetting(scanMaps);
            return scanMapSetting;
        }
    }
}
