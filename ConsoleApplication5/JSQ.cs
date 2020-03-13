using System;

namespace ConsoleApplication5
{
    class JSQ
    {
        string num1;
        string num2;
        char fh;
        public string Num1
        {
            get
            {
                return num1;

            }
            set
            {
                num1 = value;
            }
        }
        public string Num2
        {
            get
            {
                return num2;

            }
            set
            {
                num2 = value;
            }
        }
        public char Fh
        {
            get
            {
                return fh;

            }
            set
            {
                fh = value;
            }
        }
        public void Operators(float a, float b)
        {
            if (fh == '/')
                Console.WriteLine(a + "/" + b + "=" + (a / b));
            if (fh == '+')
                Console.WriteLine(a + "+" + b + "=" + (a + b));
            if (fh == '-')
                Console.WriteLine(a + "-" + b + "=" + (a - b));
            if (fh == '*')
                Console.WriteLine(a + "*" + b + "=" + (a * b));
        }
        public void Operators()
        {
            string c = num1;
            if (fh == '+')
                Console.WriteLine(num1 + "连接" + num2 + "=" + string.Concat(num1, num2));
            if (fh == '-')
            {
                char[] b = num1.ToCharArray();
                char[] a = num2.ToCharArray();
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                        if (b[i] == a[j])
                        {
                           num1= num1.Replace(a[j], ' ');
                           
                        }

                }
                Console.WriteLine(c + "除去" + num2 + "=" + num1);
            }
           

        }
        public void Equals(JSQ num)
        {
            if (num.num1 == num.num2)
                Console.WriteLine("两数相等");
        }
    }
}
