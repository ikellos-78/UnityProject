using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//명명된 인수 : 이름이 있는 인수
namespace _2025_04_28_Csharp
{
    internal class MainApp5
    {
        static void PrintProfile(string name , string phoneNum)
        {
            Console.WriteLine($"Name : {name} PhoneNumber : {phoneNum}");
        }
        static void Main(string[] args)
        {   //명명된 인수 : 이름이 있는 인수
            PrintProfile("홍길동", "010-1234-5678");
            PrintProfile(phoneNum: "010-1234-5678", name: "홍길동");
            PrintProfile(phoneNum: "010-1238-5688", name: "임꺽정");
            PrintProfile(name : "우영우", "010-1234-5678");
            PrintProfile("이순신", phoneNum: "010-1275-5788");
        }
    }
}
