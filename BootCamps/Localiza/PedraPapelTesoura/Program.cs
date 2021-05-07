using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string sheldon, raj;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                sheldon = valores[0];
                raj = valores[1];
                //complete a solução
                if(    (sheldon == "tesoura" && raj == "papel") 
                    || (sheldon == "papel" && raj == "pedra")
                    || (sheldon == "pedra" && raj == "lagarto")
                    || (sheldon == "lagarto" && raj == "Spock")
                    || (sheldon == "Spock" && raj == "tesoura")
                    || (sheldon == "tesoura" && raj == "lagarto")
                    || (sheldon == "lagarto" && raj == "papel")
                    || (sheldon == "papel" && raj == "Spock")
                    || (sheldon == "Spock" && raj == "pedra")
                    || (sheldon == "pedra" && raj == "tesoura")
                    )
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if (sheldon == raj)   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

    }

}