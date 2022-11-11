using System.ComponentModel.DataAnnotations;

public class Curriculo
    {   
        [Required]
        public IFormFile arquivo { get; set; } = null!;
    }