using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickConvertation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> list = NumberStrToByteList("123");
            foreach (var item in list)
                Console.WriteLine(item);
            Console.ReadLine();
        }

        static List<byte> NumberStrToByteList(string str)
        {
            return Array.ConvertAll(str.ToCharArray(), r => Convert.ToByte(Int16.Parse(r.ToString()))).ToList();
        }
    }
}
