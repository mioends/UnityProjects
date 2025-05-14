//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05_13_CSharp
//{
//    internal class EX1
//    {
//        private static double GetDiscountRate(object client)
//        {
//            return client switch
//            {
//                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
//                ("학생", _) => 0.1, // 학생 & 18세 이상
//                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
//                ("일반", _) => 0.05, // 일반 & 18세 이상
//                _ => 0,
//            };
//        }

//        private static double GetDiscountRate1(object client)
//        {
//            double discount = 0;

//            switch (client)
//            {
//                case Tuple<string, int> tuple:
//                    string name = tuple.Item1;
//                    int age = tuple.Item2;

//                    switch (name)
//                    {
//                        case "학생":
//                            switch (age < 18)
//                            {
//                                case true:
//                                    discount = 0.2;
//                                    break;
//                                case false:
//                                    discount = 0.1;
//                                    break;
//                            }
//                            break;

//                        case "일반":
//                            switch (age < 18)
//                            {
//                                case true:
//                                    discount = 0.1;
//                                    break;
//                                case false:
//                                    discount = 0.05;
//                                    break;
//                            }
//                            break;

//                        default:
//                            discount = 0;
//                            break;
//                    }
//                    break;

//                default:
//                    discount = 0;
//                    break;
//            }

//            return discount;
//        }

        


//    }
//}
