using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTestService;

namespace UserTestServices.Test;

public class TicketServiceTests
{
    [Test]
    public void GetTicketPriceNustReturnExistingPrice()
    {
        var ticketServiceTest = new UserTestService.TicketService();
        Assert.IsNotNull(ticketServiceTest.GetTicket(1));
    }
    [Test]
    public void GetTicketPriceMustThrowException()
    {
        var ticketServiceTest = new UserTestService.TicketService();
        Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
    }
}
