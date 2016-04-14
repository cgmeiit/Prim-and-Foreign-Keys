using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_to_array
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    int[] arr = new int[3];
        //    arr[0] = 2;
        //    arr[1] = 3;
        //    arr[2] = 5;
        //    List<int> list = new List<int>(arr);
        //    Console.WriteLine(list.Count);

        //}
        {
            int[] arr = new int[3];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 5;
            List<int> list = arr.ToList();
            Console.WriteLine(list.Count);
        }

    }
}

