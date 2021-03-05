using System;

namespace TempoEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);
    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);
           

            int transformaSegundosInicio = ((diaInicio * 24 * 60 * 60) + (horaMomentoInicio * 60 * 60) + (minutoMomentoInicio * 60) + segundoMomentoInicio);
            int transformaSegundosTermino = ((diaTermino * 24 * 60 * 60) + (horaMomentoTermino * 60 * 60) + (minutoMomentoTermino * 60) + segundoMomentoTerminio);

            int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);
            int W = somaTotalSegundos / (1 * 24 * 60 * 60);
            int hh = (somaTotalSegundos / (60 * 60)) - (W * 24);

            int mm = (somaTotalSegundos / 60) - ((W * 24 * 60)+(hh * 60));
            int ss = (somaTotalSegundos) - ((W * 24 * 60 * 60) + (hh * 60 * 60) + (mm * 60));

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", hh);
            Console.WriteLine("{0} minuto(s)", mm);
            Console.WriteLine("{0} segundo(s)", ss);

            
        }
    }
}
