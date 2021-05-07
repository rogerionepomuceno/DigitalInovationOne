using System; 

class URI {

    static void Main(string[] args) { 

            string n = Console.ReadLine();
            //continue a solução
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
           
            string v = new string(arr);
            Console.WriteLine(v);
    }

}