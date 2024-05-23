using Course.Entities.Exceptions;
using Exercisies_Try_Except.Entities;

namespace Exercisies_Try_Except {

    class Program {

        static void Main(string[] args){

        try {

            Console.WriteLine("Bem vindo ao Banco Santander");

            Console.Write("Digite o Número da Conta: ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Digite seu Nome Completo: ");
            string holder = Console.ReadLine() ?? "0";
            Console.Write("Digite seu Saldo: ");
            double balance = double.Parse(Console.ReadLine() ?? "0");

            Account account = new Account(number, holder, balance);

            Console.Write("Valor a se depositar: ");
            double amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Você depositou {amountToDeposit}");
            Console.WriteLine($"Saldo Atual: {account.Balance}");

            Console.Write("Valor a se sacar");
            double amountToWithdraw = double.Parse(Console.ReadLine());
            account.WithDraw(amountToWithdraw);

            Console.WriteLine($"Você sacou {amountToWithdraw}");
            Console.WriteLine($"Saldo Atual: {account.Balance}");

            Console.WriteLine("Painel Principal Conta:");
            
            Console.WriteLine(account);


            } catch (MovimentationException e){
                Console.WriteLine("Erro de movimentação:" + e);
            }
        }
    }
}