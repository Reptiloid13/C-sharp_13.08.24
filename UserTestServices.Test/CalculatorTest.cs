using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using UserTestService;

namespace UserTestServices.Test
{
    public class CalculatorTest
    {
        [Test]
        public void SubtractionoMustReturnResult()
        {
            var calculator = new UserTestService.Calculator();

            Assert.That(calculator.Subtraction(300, 10) == 290);

        }
        [Test]
        public void DivisionMustReturnResult()
        {
            var calculator = new UserTestService.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
        [Test]
        public void AddAlwaysReturnExpectedValue()
        {
            var calculatorTest = new UserTestService.Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            var mockTicketService = new Mock<ITicketService>();
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new UserTestService.Calculator();
            int result = calculator.Additional(50, 10, 34);
            Assert.That(result, Is.EqualTo(94));
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new UserTestService.Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.That(result, Is.EqualTo(120));
        }
    }
}
