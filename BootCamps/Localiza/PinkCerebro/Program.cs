using System; 

class PinkCerebro {

    static void Main(string[] args) { 

        int m2 = 0; // Quantidade de múltiplos de 2
        int m3 = 0; // Quantidade de múltiplos de 3
        int m4 = 0; // Quantidade de múltiplos de 4
        int m5 = 0; // Quantidade de múltiplos de 5
        
        int n = int.Parse(Console.ReadLine());

       //declare suas variaveis aqui   

        string[] valores = Console.ReadLine().Split();

      //continue a solução
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(valores[i]);
                
                if (val % 2 == 0) m2++;
                if (val % 3 == 0) m3++;
                if (val % 4 == 0) m4++;
                if (val % 5 == 0) m5++;
            }
            Console.WriteLine("{0} Multiplo(s) de 2", m2);
            Console.WriteLine("{0} Multiplo(s) de 3", m3);
            Console.WriteLine("{0} Multiplo(s) de 4", m4);
            Console.WriteLine("{0} Multiplo(s) de 5", m5);
    }

}