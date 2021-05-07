﻿using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb)
                {

                    //complete o while
                    pa += (int)Math.Truncate((pa * cpa) / 100); 
                    pb += (int)Math.Truncate((pb * cpb) / 100);
                    
                    anos++;

                    if (anos > 100)
                    {
                       Console.WriteLine("Mais de 1 seculo.");
                       break;
                    }
                }

                if (anos <= 100)
                {
                   //complete a condicional
                   Console.WriteLine("{0} anos.", anos);
                }

            }

    }

}