using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotePadAPI.DATA;
using NotePadAPI.DTOS;

namespace NotePadAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public NotesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<List<Note>> GetNotes()
        {
            return await _db.Notes.ToListAsync();
        }
        //Route vererek istenilen id değerindeki notu çekmemize yarar.
        [HttpGet("{id}")]
        public async Task<ActionResult<Note>> GetNote(int id)
        {
            var note = await _db.Notes.FindAsync(id);

            if (note == null)
                return NotFound();

            return Ok(note);
        }
        [HttpPost]
        public async Task<ActionResult<Note>> Create(NewNoteDTO dto)
        {
            if (ModelState.IsValid)
            {
                var note = new Note()
                {
                    Title = dto.Title,
                    Content = dto.Content
                };
                _db.Notes.Add(note);
                await _db.SaveChangesAsync();
                return note;
            }
            return BadRequest(ModelState);
        }
        // PUT: api/Notlar/3
        [HttpPut("{id}")]
        public async Task<ActionResult> PutNote(int id, PutNoteDTO dto)
        {
            if(ModelState.IsValid)
            {
                var note = await _db.Notes.FindAsync(id);
                if (note == null)
                    return NotFound();
                note.Title = dto.Title;
                note.Content = dto.Content;
                note.CreationTime = DateTime.Now;
                await _db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNote(int id)
        {
            var note = await _db.Notes.FindAsync(id);
            if (note == null)
                return NotFound();
            _db.Notes.Remove(note);
            await _db.SaveChangesAsync();
            return Ok();
        } 
    }
}
