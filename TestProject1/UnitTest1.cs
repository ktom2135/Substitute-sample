using System;
using ClassLibrary1;
using NSubstitute;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockPrinter = Substitute.For<Printer>();

            CashRegister cashRegister = new CashRegister(mockPrinter);
            cashRegister.Process(new Purchase());
            mockPrinter.Received(1).Print("Purchase to string");
        }
    }
}