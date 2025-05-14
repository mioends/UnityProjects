//using System.Net.Cache;
//using System.Xml.Linq;

//namespace _05_13_CSharp
//{
//    #region ReadOnly Struct
//    //readonly struct RGBColor
//    //{
//    //    public readonly byte R;
//    //    public readonly byte G;
//    //    public readonly byte B;
//    //    public RGBColor(byte r, byte g, byte b)
//    //    {
//    //        this.R = r;
//    //        this.G = g;
//    //        this.B = b;
//    //    }
//    //}
//    #endregion
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            #region 튜플 연습
//            //RGBColor Red = new RGBColor(255, 0, 0);
//            //// Red.G = 255; 상수가 되어서 오류
//            //RGBColor Green = new RGBColor(0, 255, 0);

//            ////튜플 tuple
//            //var tuple = (123, 456);
//            //Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
//            //var tuple2 = (Name:"서예지", Age: 35);
//            //Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");
//            //var tuple3 = (Name: "존레논", Age: 40, Address: "미국");
//            //var (name, age, address) = tuple3; // 분해
//            //Console.WriteLine($"이름: {name}, 나이: {age}, 주소: {address}");
//            //var num = (name: "폴매카트니", age: 80);
//            //var (Name,_) = num; // 분해. age는 무시
//            //Console.WriteLine($"이름: {Name}");
//            //var (name2, age2) = ("서예지", 35);
//            //Console.WriteLine($"이름: {name2}, 나이: {age2}");
//            //var unnamed = ("슈퍼맨", 35); // string, int
//            //var named = (name: "배트맨", Age: 36); // string, int
//            //named = unnamed; // named는 unnamed로 초기화
//            //Console.WriteLine($"{named.name}, {named.Age}");
//            #endregion

//            //var a = ("슈퍼맨", 9999); // 명명되지 않은 튜플
//            //Console.WriteLine($"{a.Item1} {a.Item2}");
//            //var b = (Name: "배트맨", Age: 46); // 명명된 튜플
//            //Console.WriteLine($"{b.Name} {b.Age}");
//            //// 분해
//            //var (name, age) = b; // b를 분해
//            //Console.WriteLine($"이름: {name}, 나이: {age}");
//            //// 분해 2
//            //var (name2, age2) = ("서예지", 35);
//            //Console.WriteLine($"이름: {name2}, 나이: {age2}");
//            //// 명명된 튜플 = 명명되지 않은 튜플
//            //b = a;
//            //Console.WriteLine($"{b.Name} {b.Age}");
//        }
//    }
//}
