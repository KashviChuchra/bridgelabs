
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Tests
{
    [TestFixture]
    public class CirculationManagerTests
    {
        [Test]
        public void CheckoutItem_ShouldAddLoanSuccessfully()
        {
            var manager = new CirculationManager();
            var loans = new List<Loan>();

            manager.CheckoutItem(loans);

            Assert.That(loans.Count, Is.EqualTo(1));
        }

        [Test]
        public void ReturnItem_ShouldSetReturnedDate()
        {
            var manager = new CirculationManager();
            var loan = new Loan(1, 101, DateTime.Today.AddDays(-5), DateTime.Today);

            manager.CheckoutItem(loans: new List<Loan>(), item: new MediaItem(1, "Book", "General"), patronId: 101, loanPeriodDays: 7);

            manager.ReturnItem(loan);

            Assert.That(loan.ReturnedDate, Is.Not.EqualTo(DateTime.MinValue));
        }

        [Test]
        public void ProcessOverdue_ShouldRaiseItemOverdueEvent()
        {
            var manager = new CirculationManager();
            var loan = new Loan(42, 12, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(-5));

            bool eventRaised = false;

            manager.ItemOverdue += (patronId, days, itemId) =>
            {
                eventRaised = true;
            };

            manager.ProcessOverdue(loan);

            Assert.That(eventRaised, Is.True);
        }

        [Test]
        public void NonCirculatingItem_ShouldThrowCustomException()
        {
            var manager = new CirculationManager();
            var loans = new List<Loan>();
            var item = new ReferenceMediaItem(100, "Reference Book", "Reference");

            Assert.Throws<ItemNotCirculatingException>(() =>
            {
                manager.CheckoutItem(loans, item, 101, 5, 3);
            });
        }

        [Test]
        public void ReturnItem_WhenNeverCheckedOut_ShouldThrowInvalidOperationException()
        {
            var manager = new CirculationManager();
            var loan = new Loan(100, 101, DateTime.Today, DateTime.Today.AddDays(10));

            loan.ReturnedDate = DateTime.MinValue;

            Assert.Throws<InvalidOperationException>(() =>
            {
                manager.ReturnItem(loan);
            });
        }

        [Test]
        public void CreateOverdueRule_ChangingLoanPeriod_ShouldChangeResult()
        {
            var manager = new CirculationManager();
            var loan = new Loan(1, 101, DateTime.Today.AddDays(-10), DateTime.Today);

            var sevenDayRule = manager.CreateOverdueRule(7);
            var fourteenDayRule = manager.CreateOverdueRule(14);

            bool resultForSevenDays = sevenDayRule(loan);
            bool resultForFourteenDays = fourteenDayRule(loan);

            Assert.That(resultForSevenDays, Is.Not.EqualTo(resultForFourteenDays));
        }

        [Test]
        public void LoanCountByPatron_ShouldReturnCorrectCount()
        {
            var manager = new CirculationManager();

            var loans = new List<Loan>
            {
                new Loan(1, 101, DateTime.Today.AddDays(-5), DateTime.Today),
                new Loan(2, 101, DateTime.Today.AddDays(-3), DateTime.Today.AddDays(7)),
                new Loan(3, 102, DateTime.Today.AddDays(-2), DateTime.Today.AddDays(8))
            };

            int count = manager.LoanCountByPatron(loans, 101);

            Assert.That(count, Is.EqualTo(2));
        }

        [Test]
        public void CirculationLogger_AfterDispose_ShouldThrowObjectDisposedException()
        {
            string filePath = Path.Combine(TestContext.CurrentContext.WorkDirectory, "test-log.txt");
            var logger = new CirculationLogger(filePath);

            logger.Dispose();

            Assert.That(logger.IsDisposed, Is.True);

            Assert.Throws<ObjectDisposedException>(() =>
            {
                logger.Log("This should fail");
            });
        }
    }
}

