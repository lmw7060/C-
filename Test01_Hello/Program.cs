using System;
using static System.Console;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Program pgm = new Program();
//            int i = pgm.function();
            Test01 Sub = new Test01();
            Sub.MainFunc();
        }
/*        int function()
        {
            while (true)
            {

            }
            return 0;
        }*/
    }
    class Test01    //main class
    {
/*        public Test01()
        {
            Console.WriteLine("Hello World~!");
        }*/
        public void MainFunc() 
        {
            int i = 10, j= 20;
            double d = 1.5, e = 3.1;
            object o = i + 1;
            WriteLine("Hello World({0},{1},{4})\nMain Function~!({2},{3})", i,j,d,e,o);  //printf함수
            o = d + 0.5;
            WriteLine("Hello World({0},{1},{4})\nMain Function~!({2},{3})", i, j, d, e, o);  //printf함수
            while (true)
            {
                try
                {
                    WriteLine("두개의 정수를 입력하세요");
                    string str = Console.ReadLine();
                    i = int.Parse(str.Split(' ')[0]);
                    j = int.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 정수는 ({i},{j})이다.");  //printf함수

                    WriteLine("두개의 실수를 입력하세요");
                    str = ReadLine();
                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 실수는 ({d},{e})이다.");  //printf함수
                    /*string str = "STX" + i.ToString() + "ETX";
                    string st1 = $"STX{i,5}ETX";
                    WriteLine(str);
                    Console.WriteLine(st1);*/

                    /*            int[] arr = new int[100];
                                for (int i = 0; i <100; i++) { arr[i] = i;}*/
                }
                catch (Exception e1)
                {
                    WriteLine(e1.Message);
                }
            }
        }
    }
}
