using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Chuan
    {
        string c;
        public string C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public void Change(Chuan a)
        {
            string b;
            int count = 0;
            char []arr=a.c.ToCharArray();
            int[] Arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 48 && arr[i] <= 57)
                {
                    b = arr[i].ToString();
                    Arr[count]=int.Parse(b);
                    Console.Write(Arr[count]);
                    count++;
                   
                }
            }
        }
    }
}
