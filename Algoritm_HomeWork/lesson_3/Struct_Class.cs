using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.lesson_3
{
    public class Struct_Class : ILesson
    {
        public string Name => "3";

        public string Description => "Перформанс Struct vs Class";

        public void Run()
        {
            Struct_Class_Performance.Benchmark();
            Console.ReadLine();
        }
    }
}
