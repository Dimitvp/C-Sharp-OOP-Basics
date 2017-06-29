
    using System;

class BankAccount
    {
        private int id;
        private double balance;

        public int ID { get; set; }

        public double Balance
        {
        get { return this.balance; }
            set
            {
                if (this.balance + value < 0)
                {
                    throw new ArgumentException("Balance can not be negative");
                }
            }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Withraw(double amount)
        {
            this.Balance -= amount;
        }
}