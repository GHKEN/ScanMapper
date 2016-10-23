using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanMapEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = Repository.ScanMapSetting.Get();
            Console.WriteLine(BitConverter.ToString(setting));
            Console.Read();
        }
    }
}
