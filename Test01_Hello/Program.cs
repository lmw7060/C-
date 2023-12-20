using System;
using static System.Console;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    static class myLib 
    {
        //(argument) str - "1 2 3" or "1, 2, 3" , n(n번쨰) ,(separate) ch - ',',','
        public static string GetToken(string str, int n, char ch)
        {
            return str.Split(ch)[n];
        }
    }
    class Point
    {
        int x, y;
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public double Dist(Point p1)
        {
            int d1 = p1.x - x;
            int d2 = p1.y - y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
        public static double operator - (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Sqrt(d1* d1 + d2* d2);
        }
        public static double operator * (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Abs(d1  *  d2);
        }
    }
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
        delegate void cbTest();
        void f1() {WriteLine("delegate Test 01");}
        void f2() { WriteLine("delegate Test 02"); }
        void f3() { WriteLine("delegate Test 03"); }
        void Func_DelegateTest() 
        {
            cbTest cb;
            cb = new cbTest(f1); cb();
            cb = new cbTest(f2); cb();
            cb = new cbTest(f3); cb();
        }
        public void Func_PointTest()
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            WriteLine($"두 점 P1(10,20)과 P2(30,40)의 거리는 {p1.Dist(p2):F2} {p1-p2}입니다.");
            WriteLine($"면적은 {p1 * p2} 입니다.");
            string s1 = "GOOD";
            string s2 = "morning";
            string s3 = s1 + s2;
        }
        public void Func_ReadWrite()
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;
            object o = i + 1;
            var v = i * 10;
            Console.WriteLine("Hello World({0},{1},{4})\nMain Function~!({2},{3})", i, j, d, e, o);  //printf함수
            o = d + 0.5;
            v = j * 10;
            //            int k = sizeof(int);
            Console.WriteLine("Hello World({0},{1},{4})\nMain Function~!({2},{3})", i, j, d, e, o);  //printf함수
            Console.WriteLine("i:{0} j:{1} d:{2} e:{3},o:{4}", i, j, d, e, o);  //printf함수
            Console.WriteLine($"i:{sizeof(int)} j:{sizeof(double)}");
            //              sizeof(object) sizeof(var) xxxxxxxxxxxxx


            int[] arr = new int[i];
            for (int i1 = 0; i1 < 10; i1++)
            {
                arr[i1] = i1;
            }




            //            myLib my =new myLib();
            //            while (true)
            {
                try
                {
                    Console.WriteLine("두개의 정수를 입력하세요");
                    string str = Console.ReadLine();
                    //                    i = int.Parse(str.Split(' ')[0]);
                    i = int.Parse(myLib.GetToken(str, 0, ' '));
                    j = int.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 정수는 ({i},{j})이다.");  //printf함수

                    Console.WriteLine("두개의 실수를 입력하세요");
                    str = Console.ReadLine();
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
                    Console.WriteLine(e1.Message);
                }
            }
        }
        int ArrSum(int[] arr)       //int 배열요소의 합
        {
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];  
            }
            return sum;
        }
        T ArrSum2<T>(T[] arr)
        {
            int i = 0;
            foreach(T a in arr) { }
            
            return arr[0];
        }
        void PrintArr<T>(T[] arr)
        {
            int i = 0;
            foreach (T a in arr)
            {
                Write($"[{i++}]{a}  ");
            }
        }
        void InitArr(out int[] arr,int n) 
        {
            arr = new int[n];
            /*foreach (int a in arr)
            {
                arr[a] = a;
            }   */
            for (int i = 0; i < 10; i++) arr[i] = i;
        }       //arr 초기화
        void CallArr(int[] arr)         
        {
            arr[2] = 100;
            arr[4] = 200;
        }
        public void Func_ArrayTest()
        {
            string s1 = "Good";
            string s2 = "Morning";

            int[] arr;// = new int[10];
            int[] arr2 = { 0, 1, 2, 3, 4 };
            Point[] parr = new Point[10];
            int[,] brr = { { 0, 1, 2, 3, 4 }, { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 } };
            int[][] crr =
                { 
                    new int[] { 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 },
                    new int[] { 10, 11, 12, 13, 14, 15, 16 },
                    new int[] { 20, 21, 22, 23, 24 }
            };
            int[][][] drr =
            {
                new int[][]
                {
                    new int[] { 10, 11, 12, 13, 14}
                },
                new int[][]
                {
                    new int[] { 20, 21, 22, 23, 24}
                }
            };
            double[] err = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6 };

            InitArr(out arr, 10); for(int i=0; i<10; i++) Write($"arr[{i}]:{arr[i]}   "); WriteLine("");
            
            crr[0].CopyTo(arr,0); for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}   "); WriteLine("");
            
            CallArr(arr); for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}   "); WriteLine("");

            Array.Copy(crr[0],arr, 6);

            for (int i = 0; i < 3; i++) 
            {
                for(int j = 0; j < 5; j++) 
                {
                    Write($"brr[{i},{j}]:{brr[i, j]}   ");
                }
                WriteLine("\r\n");
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < crr[i].Length; j++)
                {
                    Write($"crr[{i}][{j}]:{crr[i][j]}   ");
                }
                WriteLine("\r\n");
            }

            WriteLine($"Sum of [arr] : {ArrSum(arr)}");
            WriteLine($"Sum of [err] : {ArrSum2(err)}");
            //            WriteLine($"Length of [arr] : {arr.Length}");
            //int arr3 = arr + arr2;
            arr.Append<int>(1);
            WriteLine(s1 + s2);
            WriteLine($"Length of [arr] : {arr.Length}");
        }
        public void MainFunc()  ///주 진입점(실행 함수)
        {
            //Func_PointTest(); return;         //point test
            //Func_ReadWrite(); return;         //readwrite
            //Func_ArrayTest(); return;         //array test
            Func_DelegateTest(); return;        //delegate test
        }
    }
}
