using System.ComponentModel.DataAnnotations;

namespace IMDBLite.Models;
public class Movie{
    public int Id { get; set; }
    
    public string? Title { get; set; }

    [DataType(DataType.Date)]        
    public DateOnly ReleaseDate { get; set; }

    public long Lenght { get; set; }
}