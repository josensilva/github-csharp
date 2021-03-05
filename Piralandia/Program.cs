using System;

namespace Piralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            //continue a solução
            char[] entrada = n.ToCharArray();
            int a = 0;
            char[] arr = new char[n.Length];

            for(int i = entrada.Length - 1; i >= 0; i--)
            {
                arr[a] = entrada[i];
                a++;
            }          
           
            string v = new string(arr);
            Console.WriteLine(v);
        }
    }
}
