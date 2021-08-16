using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModule
{
    class Program
    {
        
        public static object TestModule(object obj)
        {
           
            string str = "";
            int three = 3;


            switch (obj)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    return Convert.ToInt32(obj) * 2;

                case object x when x.GetType() == typeof(String):
                    return x.ToString().ToUpper();

                case object x when Convert.ToInt32(x) > 4 :
                    return Convert.ToInt32(x) * 3;                    

                case object x when Convert.ToInt32(x) < 1:
                    return "Invalid input exception";

                case object x when  (float)Convert.ToInt32(x) == 1.0f || (float)Convert.ToInt32(x) == 2.0f:
                    return 3.0f;            
                default:
                    return obj;
            }
                
            
        }
        static void Main(string[] args)
        {
            object obj = 0;
            var result = TestModule(obj);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
