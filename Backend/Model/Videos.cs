public class Videos
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string VideoURL { get; set; }
    public int NumberOfLikes { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}