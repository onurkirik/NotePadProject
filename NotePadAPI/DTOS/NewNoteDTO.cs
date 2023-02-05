using System.ComponentModel.DataAnnotations;

namespace NotePadAPI.DTOS
{
    public class NewNoteDTO
    {
        [MaxLength(200)]
        public string Title { get; set; } = null!;
        public string? Content { get; set; } = string.Empty;
    }
}
