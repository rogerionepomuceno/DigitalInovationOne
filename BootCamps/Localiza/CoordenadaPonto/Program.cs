using System; 

class URI {

    static void Main(string[] args) { 

        //implemente sua solução aqui
        string[] valores = Console.ReadLine().Split();
        double n1 = double.Parse(valores[0]);
        double n2 = double.Parse(valores[1]);

        if (n1 == 0 && n2 == 0)
            Console.WriteLine("Origem");
        else
        if (n1 == 0)
            Console.WriteLine("Eixo Y");
        else
        if (n2 == 0)
            Console.WriteLine("Eixo X");
        else
        if (n1 > 0 && n2 > 0)
            Console.WriteLine("Q1");
        else
        if (n1 < 0 && n2 > 0)
            Console.WriteLine("Q2");
        else
        if (n1 < 0 && n2 < 0)
            Console.WriteLine("Q3");
        else
            Console.WriteLine("Q4");
    }

}