using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson7
{
   public class HomeWork7 : ILesson
    {
        public string Name => "7";

        public string Description => "Реализовать нахождение всех решений задачи о восьми ферзях";

        public void Run()
        {
            Board.Run();
        }
    }
}
