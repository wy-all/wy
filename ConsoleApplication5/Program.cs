using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            JSQ jsq = new JSQ();
            float  a, b;
            a=b=0;
            
            while (true)
            {
                Console.WriteLine("输入第一个数");
                jsq.Num1 = Console.ReadLine();
                Console.WriteLine("输入一个运算符");
                string input3 = Console.ReadLine();
                Console.WriteLine("输入第二个数");
                jsq.Num2 = Console.ReadLine();
                

                try
                {
                    a = float.Parse(jsq.Num1);
                    b = float.Parse(jsq.Num2);
                    jsq.Fh = char.Parse(input3);
                }
                catch (Exception e)
                {
                    Console.WriteLine("错误是："+e);
                }
                jsq.Equals(jsq);
                jsq.Operators();
                jsq.Operators(a,b);

                Console.WriteLine("请继续！！");
            }
           
        }
    }
}
