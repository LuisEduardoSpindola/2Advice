namespace Domain.Models.Advice;

public class Advice
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string AuthorName { get; set; }
    public string Image { get; set; }
    public string TypeContent { get; set; }
    public string Course { get; set; } 
    public DateTime PostDate { get; set; }
    public DateTime Validity { get; set; }
}