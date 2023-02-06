namespace GloboTickect.TicketMangement.Domain.events
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrederPaid { get; set; }
    }
}
