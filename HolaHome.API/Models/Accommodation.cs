namespace HolaHome.API.Models
{
    public class Accommodation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }

    }
}
