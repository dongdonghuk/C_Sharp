using System;


namespace Bank
{
    class BankAccount
    {
        private decimal balance;
        private string name;

        public BankAccount()
        {
            name = "noName";
            balance = 0;
        }

        public void SetName(string _name)
        { name = _name; }

        public void Deposit(int money)
        { balance += money; }

        public string GetName()
        { return name; }

        public decimal GetBalance()
        { return balance; }

        public void Withdraw(int money)
        {
            if(money > balance)
            {
                Console.WriteLine("잔고부족, 현재잔고 : {0}", balance);
                return;
            }
            balance -= money; 
        }
    }


    class Bank_Class
    {
    }
}
