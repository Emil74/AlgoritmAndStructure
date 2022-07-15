using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoritm_HomeWork.lesson_3.Struct_Class_Performance;

namespace Algoritm_HomeWork.lesson_3
{
    public class Struct_Class_Performance
    {
        public static void Benchmark()
        {

            BenchmarkRunner.Run<BechmarkClass>();
        }

        public struct PointStructDouble
        {

            public double X { get; set; }
            public double Y { get; set; }
        }


        public class PointClassDouble
        {
            public double X { get; set; }
            public double Y { get; set; }
        }


        public static PointStructDouble[] BenchStructArray()
        {
            PointStructDouble[] array = new PointStructDouble[2];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                PointStructDouble psd = new PointStructDouble();
                psd.X = random.Next(1, 100);
                psd.Y = random.Next(1, 100);
                array[i] = psd;

            }
            return array;
        }

        public static PointClassDouble[] BenchClassArray()
        {
            PointClassDouble[] array = new PointClassDouble[2];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                PointClassDouble pcd = new PointClassDouble();
                pcd.X = random.Next(1, 100);
                pcd.Y = random.Next(1, 100);
                array[i] = pcd;

            }
            return array;
        }
    }

    public class BechmarkClass
    {
        [Benchmark]
        public void PointDistanceStruct()
        {
            PointStructDouble[] array = Struct_Class_Performance.BenchStructArray();
            double x = array[1].X - array[0].X;
            double y = array[1].Y - array[0].Y;

            Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public void PointDistanceClass()

        {

            PointClassDouble[] array = Struct_Class_Performance.BenchClassArray();
            double x = array[1].X - array[0].X;
            double y = array[1].Y - array[0].Y;
            Math.Sqrt((x * x) + (y * y));
        }
    }
}

