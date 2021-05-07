using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

            int transformaSegundosInicio = (horaMomentoInicio * 3600) + (minutoMomentoInicio * 60) + segundoMomentoInicio;
            int transformaSegundosTermino = (horaMomentoTermino * 3600) + (minutoMomentoTermino * 60) + segundoMomentoTerminio;

            int somaTotalSegundos = ((diaTermino - diaInicio) * 24 * 3600) + transformaSegundosTermino - transformaSegundosInicio;

            int dias = somaTotalSegundos / 3600 / 24;
            somaTotalSegundos = somaTotalSegundos - (dias * 3600 * 24);
            int horas = somaTotalSegundos / 3600;
            somaTotalSegundos = somaTotalSegundos - (horas * 3600);
            int minutos = somaTotalSegundos / 60;
            somaTotalSegundos = somaTotalSegundos - (minutos * 60);
            int segundos = somaTotalSegundos;
                    
            Console.WriteLine("{0} dia(s)", dias);
            Console.WriteLine("{0} hora(s)", horas);
            Console.WriteLine("{0} minuto(s)", minutos);
            Console.WriteLine("{0} segundo(s)", segundos);
    }

}