namespace MVCBasics.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string ReviewerName { get; set; }
        public int Raiting { get; set; }
    }
}