using System.ComponentModel.DataAnnotations;

namespace NotePadAPI.DATA
{
    public class Note
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; } = null!;
        public string? Content { get; set; } = string.Empty;
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
    }
}
