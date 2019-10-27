using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeapYear();
            //NewPivot();

            //Fisiere();
            //LinkList3El();
            RevLinkList();
            Console.ReadLine();
        }

        private static void RevLinkList()
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedList<int> copylist = new LinkedList<int>(); 
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            var start=list.AddLast(50);
            while(start!=null)
            {
                copylist.AddLast(start.Value);
                start = start.Previous;
            }
            list = copylist;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        private static void LinkList3El()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            int numara = 0;

            foreach (var item in list)
            {
                numara++;
                if(numara==list.Count-2)
                {
                    Console.WriteLine(item);
                }
            }
        }


        private static void NewPivot()
        {
            int n, pivot, j = 0;
            Console.WriteLine("introduceti marimea vect: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[n];
            int[] piv = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"a[{i}]=");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("introduceti pozitia dupa care vreti sa rotiti: ");
            pivot = Convert.ToInt32(Console.ReadLine());

            for (int i = pivot+1; i < arr.Length; i++)
            {
                piv[j] = arr[i];
                j++;
            }
            piv[j] = arr[pivot];
            
            if(j<arr.Length)
            {
                j++;
                for (int i = 0; i < pivot; i++)
                {
                    piv[j] = arr[i];
                    j++;
                }
            }
            for (int i = 0; i < piv.Length; i++)
            {
                Console.WriteLine($"a[{i}]={piv[i]}");
            }




        }

        private static void Fisiere()
        {
            var path = @"C:\Users\Bogdan\Desktop\Programare\fisier.txt";
            int sum = 0;
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < 2; i++)
            {
                sum += Convert.ToInt32(lines[i]);
            }
            var a = sum.ToString();
            //File.AppendAllText(path, a + Environment.NewLine);

            string[] arrLine = File.ReadAllLines(path);
            arrLine[3 - 1] = a;
            File.WriteAllLines(path, arrLine);

            //lines[3] = a;
        }

        private static void LeapYear()
        {
            int an;
            Console.WriteLine("Introduceti un an: ");
            an = Convert.ToInt32(Console.ReadLine());

            if((an%4==0&& an%100!=0)||an%400==0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }
    }
}
