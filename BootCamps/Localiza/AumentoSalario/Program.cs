using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double salario = 0.00, reajuste = 0.00, novoSalario = 0.00, percentual = 0.00;
            
            salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado

            if (salario < 0.00)
            {
                return;
            }
            else if(salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
//                percentual = 15;
            }
            else if (salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
//                percentual = 12;
            }
            else if (salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
//                percentual = 10;
            }
            else if (salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
//                percentual = 7;
            }
            else if (salario > 2000)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
//                percentual = 4;
            }
            else
            {
                return;
            }
            if (salario == 0)
                  percentual = 15;
            else
                  percentual = System.Math.Round((((novoSalario - salario) * 100) / salario), 0);

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
   }
}