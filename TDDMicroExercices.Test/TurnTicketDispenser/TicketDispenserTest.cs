namespace TDDMicroExercices.TurnTicketDispenser
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TDDMicroExercises.TurnTicketDispenser;

    [TestClass]
    public class TicketDispenserTest
    {
        [TestMethod]
        public void WhenInitializedThenInstanceOk()
        {
            var dispenser = new TicketDispenser();

            Assert.IsNotNull(dispenser);
        }

        [TestMethod]
        public void WhenFirstTicketThenNumberIs0()
        {
            var dispenser = new TicketDispenser();
            
            var ticket = dispenser.GetTurnTicket();
            
            Assert.AreEqual(0, ticket.TurnNumber);
        }



        [TestMethod]
        public void WhenFourthTicketThenNumberIsNot0()
        {
            var dispenser = new TicketDispenser();

            var ticket = dispenser.GetTurnTicket();

            Assert.AreNotEqual(0, ticket.TurnNumber);
        }

        


        [TestMethod]
        public void WhenSeveralTicketsPickedThenLatestIsBiggest()
        {
            var firstDispenser = new TicketDispenser();
            var secondDispenser = new TicketDispenser();

            var firstTicket = firstDispenser.GetTurnTicket();
            var secondTicket = secondDispenser.GetTurnTicket();

            Assert.IsTrue(secondTicket.TurnNumber > firstTicket.TurnNumber);
        }

    }
}
