using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            mediaP = 0;
            //complete com as variaveis
            if (a >= 0 && b >= 0) 
               mediaP = ((a * 3.5) + (b  * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
    }

}