using System;
using System.Collections.Generic;

namespace Banco
{
    class Program
    {
        private static List<Conta> listConta = new List<Conta>();

        static void Main(string[] args)
        {
            string opcao;
            uint numeroConta;
            string nome;
            int tipoConta;
            decimal saldo;
            decimal limite;
            uint numeroContaDestino;
            decimal valor;
            Conta conta;
            Conta contaDestino;

            do 
            {
                Console.Clear();
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Transferir");
                Console.WriteLine("4 - Cadastrar uma conta");
                Console.WriteLine("5 - Listar todas as contas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");
                
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Console.Write("Informe o número da conta: ");
                            numeroConta = uint.Parse(Console.ReadLine());
                            if (localizaConta(numeroConta, out conta))
                            {
                                Console.Write("Informe o valor: ");
                                valor = decimal.Parse(Console.ReadLine());
                                if (!conta.sacar(valor))
                                {
                                    Console.WriteLine("Saldo insuficiente!");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Saldo após o saque: " + conta.getSaldo());
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Conta inexistente!");
                                System.Threading.Thread.Sleep(2000);
                            }
                            break;
                    case "2": Console.Write("Informe o número da conta: ");
                            numeroConta = uint.Parse(Console.ReadLine());
                            if (localizaConta(numeroConta, out conta))
                            {
                                Console.Write("Informe o valor: ");
                                valor = decimal.Parse(Console.ReadLine());
                                conta.depositar(valor);
                                Console.WriteLine("Saldo após o depósito: " + conta.getSaldo());
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Conta inexistente!");
                                System.Threading.Thread.Sleep(2000);
                            }
                            break;
                    case "3": Console.Write("Informe o número da conta origem: ");
                            numeroConta = uint.Parse(Console.ReadLine());
                            if (localizaConta(numeroConta, out conta))
                            {
                                Console.Write("Informe o número da conta destino: ");
                                numeroContaDestino = uint.Parse(Console.ReadLine());
                                if (localizaConta(numeroContaDestino, out contaDestino))
                                {
                                    Console.Write("Informe o valor: ");
                                    valor = decimal.Parse(Console.ReadLine());
                                    if (conta.sacar(valor))
                                        contaDestino.depositar(valor);
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente!");
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Conta inexistente!");
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Conta inexistente!");
                                System.Threading.Thread.Sleep(2000);
                            }
                            break;
                    case "4": Console.Write("Informe o número da conta: ");
                            numeroConta = uint.Parse(Console.ReadLine());
                            if (localizaConta(numeroConta, out conta))
                            {
                                Console.Write("Conta já existente!");
                                System.Threading.Thread.Sleep(2000);
                                continue;
                            }
                            Console.Write("Informe o nome do titular: ");
                            nome = Console.ReadLine();
                            do
                            {
                                Console.Write("Informe o tipo da conta (1-Pessoa Física e 2-Pessoa Jurícia): ");
                                tipoConta = int.Parse(Console.ReadLine());

                            } while (tipoConta != (int)TipoConta.PessoaFisica && tipoConta != (int)TipoConta.PessoaJuridica);
                            Console.Write("Informe o saldo inicial: ");
                            saldo = decimal.Parse(Console.ReadLine());
                            Console.Write("Informe o limite: ");
                            limite = decimal.Parse(Console.ReadLine());
                            listConta.Add(new Conta(numeroConta, nome, (TipoConta) tipoConta, saldo, limite));
                            break;                            
                    case "5": for (int i = 0; i < listConta.Count; i++)
                            {
                                Console.WriteLine(listConta[i].ToString());
                            }
                            Console.Write("Pessione ENTER para continuar");
                            Console.Read();
                            break;
                }
            } while (opcao != "0");
            

        }

        private static bool localizaConta(uint numeroConta, out Conta conta)
        {
            conta = null;
            for(int i = 0; i < listConta.Count; i++)
            {
                if(listConta[i].getNumeroConta() == numeroConta)
                {
                    conta = listConta[i];
                    return true;
                }
            }
            return false;
        }
    }
}


