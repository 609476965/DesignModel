using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {
    class Program {
        static void Main(string[] args) {
            Data data = new Data();
            DisplayOne disO = new DisplayOne(data);
            DisplayTwo disT = new DisplayTwo(data);
            data.SetData(1, 2, 3);
            data.SetData(5, 5, 5);
            Console.Write("请按任意键继续...");
            Console.ReadKey();
        }
    }
}
