namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class MovieResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TicketPrice { get; set; }
        public string MovieName { get; set; }
        public string LeadActor { get; set; }
        public int ReleaseYear { get; set; }
        public string Plot { get; set; }
        public bool Oscar { get; set; }
    }
}