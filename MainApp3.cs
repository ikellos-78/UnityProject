﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2025_04_28_Csharp
//{
//    internal class MainApp3
//    {
//        //참조에 의한 매개변수 전달
//        public static void Swap(ref int a,ref int b)
//        {
//            int temp = b;
//            b = a;
//            a = temp;
//            Console.WriteLine($"{a} {b}");
//        }

//        public static void Swap(ref int a,ref int b, ref int c)
//        {
//            int temp = c;
//            c = a;
//            a = temp;
//        }
//        public static void Swap(ref float a, ref float b)
//        {
//            float temp = b;
//            b = a;
//            a = temp;
//            Console.WriteLine($"{a} {b}");
//        }
//        static void Main(string[] args)
//        {
//            //int x = 3;
//            //int y = 5;
//            //Console.WriteLine($"x : {x}, y : {y}");
//            //Swap(ref x, ref y); //호출 한 후 다음줄에서 메모리가 사라짐
//            //Console.WriteLine($"x : {x}, y : {y}");

//            int a = 3;
//            int b = 5;
//            int c = 7;
//            Console.WriteLine($"a : {a}, b : {b}, c : {c}");
//            Swap(ref a, ref b, ref c);
//            Console.WriteLine($"a : {a}, b : {b}, c : {c}");

//        }
//    }
//}
