

using Course.Entities.Exceptions;

namespace Exercisies_Try_Except.Entities {

    public class Account {

        public int Number {get; set;}
        public string Holder {get; set;}
        public double Balance {get; set;}
        public double WithdrawLimit {get; private set;} = 1000.00;

        public Account () { }

        public Account (int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public Account (int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amountToDeposit) {
            Balance += amountToDeposit;
        }
        public void WithDraw(double amountToWithdraw) {
            
            // menor que o saldo
            if (amountToWithdraw > Balance) {

                throw new MovimentationException("O valor a sacar é maior que o saldo da conta! ");
            }
            if (amountToWithdraw > WithdrawLimit) {

                throw new MovimentationException("O valor a sacar atingiu o limite de saque");
            }

            Balance -= amountToWithdraw;
        }

        public override string ToString()
        {
            return $"Conta número: {Number} - Proprietário: {Holder} - Saldo: {Balance}";
        }
    }
}