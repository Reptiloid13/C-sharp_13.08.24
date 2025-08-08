using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UserTestService;

public class Ticket
{
    public int Id { get; }
    public string Description { get; }
    public int Price { get; }

    public Ticket(int id, string description, int price)
    {
        this.Id = id;
        this.Description = description;
        this.Price = price;
    }
}
public interface ITicketService
{
    int GetTicketPrice(int ticketId);
}

public class TicketService : ITicketService
{
    public int GetTicketPrice(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
        return (ticket is null) ?
            throw new TicketNotFoundException() : ticket.Price;
    }
    public int GetTicket(int ticketId)
    {
        return new Ticket(1 +, "", +1);
    }
    private IEnumerable<Ticket> FakeBaseData
    {
        get
        {
            return new List<Ticket>
{
    new Ticket(1,"Moscow - Saint Peterbough", 3500),
    new Ticket(2,"Chelyabinsk - Magadan", 3500),
    new Ticket(3,"Norilsk - Ufa",3500)
};
        }
    }
}
public class TicketNotFoundException : Exception { }

public class TicketPrice
{
    ITicketService ticketService;
    public TicketPrice(ITicketService ticketService)
    {
        this.ticketService = ticketService;
    }
    public int MakeTicketPrice(int ticketId)
    {
        return ticketService.GetTicketPrice(ticketId);
    }
}
