using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            JSQ jsq = new JSQ();
            float  a=0, b=0;
            Console.WriteLine("请输入表达式，输入一个字符按一下回车！！！");
            while (true)
            {
                jsq.Num1 = Console.ReadLine();
                string input3 = Console.ReadLine();
                jsq.Num2 = Console.ReadLine();
                

                try
                {
                    a = float.Parse(jsq.Num1);
                    b = float.Parse(jsq.Num2);
                    jsq.Fh = char.Parse(input3);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                jsq.Equals(jsq);
                jsq.Operators();
                jsq.Operators(a,b);

                Console.WriteLine("请继续！！");
            }
            //Chuan chuan = new Chuan();
            //Console.WriteLine("请输入字符串");
            //chuan.C = Console.ReadLine();
            //chuan.Change(chuan);
        }
    }
}
