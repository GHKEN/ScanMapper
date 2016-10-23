using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ScanMapEditor.Repository
{
    class ScanMapSetting
    {
        public static byte[] Get()
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Keyboard Layout", false);

            byte[] byteArray = (byte[])regKey.GetValue("Scancode Map");
            return byteArray;
        }
    }
}
