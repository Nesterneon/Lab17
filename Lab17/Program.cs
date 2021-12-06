using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>(010, 11200, "Нестеренко Екатерина Владимировна");
            Bank<string> bank2 = new Bank<string>("А110", 11200, "Нестеренко Екатерина Владимировна");
            bank2.Print1("Нестеренко Екатерина Владимировна");
            bank1.Print2(11200);
            bank2.Print3<string>("А110");
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        private T Сheck { get; set; }
        private int Balance { get; set; }
        private string Fullname { get; set; }

        public Bank(T check, int balance, string fullname)
        {
            this.Сheck = check;
            this.Balance = balance;
            this.Fullname = fullname;
        }
        public void Print1(string Fullname)
        {
            this.Fullname = Fullname;
            Console.WriteLine("ФИО:{0}", Fullname);
        }
        public void Print2(int Balance)
        {
            this.Balance = Balance;
            Console.WriteLine("баланс:{0}", Balance);
        }
        public void Print3<U>(T Сheck)
        {
            this.Сheck = Сheck;
            Console.WriteLine("номер счета: {0}", Сheck);
        }
    }
}