//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace _2025_04_28_Csharp
//{
//    public class Calculator
//    {
//        public static int Pluse(int a, int b)
//        {
//            return a + b;
//        }
//        public static int Minus(int a, int b)
//        {
//            return a - b;
//        }
//        public static int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//        public static int Divide(int a, int b)
//        {
//            return a / b;
//        }

//    }

//    public class MainApp
//    {
//        static void Main(string[] args)
//        {
//            #region 동적 할당
//            //객체생성
//            //정적할당 동적할당의 차이
//            //정적할당 : 메모리 할당이 컴파일 시점에 결정
//            //동적할당 : 메모리 할당이 런타임 시점에 결정
//            //Calculator cal = new Calculator();
//            //int result = cal.Pluse(10, 20);
//            //Console.WriteLine(result);
//            //result = cal.Minus(30, 20);
//            //Console.WriteLine(result);
//            //result = cal.Multiply(40, 20);
//            //Console.WriteLine(result);
//            #endregion

//            #region 정적할당

//            int result = Calculator.Pluse(10, 20);
//            Console.WriteLine(result);
//            result = Calculator.Minus(30, 20);
//            Console.WriteLine(result);
//            result = Calculator.Multiply(30, 40);
//            Console.WriteLine(result);

//            #endregion

//        }

//    }
//}
