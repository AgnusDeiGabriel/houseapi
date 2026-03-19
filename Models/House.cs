namespace HouseApi.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Location { get; set; } = "";
        public double Price { get; set; }
        public string ImageUrl { get; set; } = "";
    }
}