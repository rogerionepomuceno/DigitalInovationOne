using System;
using System.Collections.Generic;

class ComprasSupermercado {
  public static void Main (string[] args) {
    // Número de listas de compras
    var n = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < n; i++) {
        string[] produtos = Console.ReadLine().Split();
        List<string> listaCompra = new List<string>(); 
        // Flag
        for(int j = 0; j < produtos.Length; j++) {
            bool existe = false;
            for(int k = 0; k < listaCompra.Count; k ++) {
                if (produtos[j].Equals(listaCompra[k])) {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                listaCompra.Add(produtos[j]);
        }
        for(int j = 0; j < listaCompra.Count - 1; j++)
            for(int k = j + 1; k < listaCompra.Count; k++)
                if (String.Compare(listaCompra[j], listaCompra[k]) > 0)
                {
                    string temp = listaCompra[j];
                    listaCompra[j] = listaCompra[k];
                    listaCompra[k] = temp;
                }
        for(int j = 0; j < listaCompra.Count; j++)
            Console.Write(listaCompra[j] + " ");
        Console.WriteLine();
    }

  }
}