using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson6
{
    public class Louncher
    {
        private static List<ILesson> works = new List<ILesson>();
        public static String[] GetList()
        {
            List<Type> homeWorkList = new List<Type>();
            homeWorkList.AddRange(collection: Assembly.GetCallingAssembly().GetTypes().Where(t => t.GetInterfaces().Any(i => i == typeof(ILesson))));

            List<string> tmp = new List<string>();

            for (int i = 0; i < homeWorkList.Count; i++)
            {
                works.Add((ILesson)Activator.CreateInstance(homeWorkList[i]));
                tmp.Add($"{works[i].Name} {works[i].Description}");
            }
            return tmp.ToArray();
        }

        public static void Run(int value)
        {
            works[value].Run();
        }
    }
}
