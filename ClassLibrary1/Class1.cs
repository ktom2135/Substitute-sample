using System;

namespace ClassLibrary1
{
    public class Printer
    {
        public virtual void Print(string st)
        {
        }
    }

    public class CashRegister
    {
        private readonly Printer _printer;

        public CashRegister(Printer printer)
        {
            _printer = printer;
        }

        public void Process(Purchase purchase)
        {
            _printer.Print(purchase.ToString());
        }
    }

    public class Purchase
    {
        public override string ToString()
        {
            return "Purchase to string";
        }
    }
}