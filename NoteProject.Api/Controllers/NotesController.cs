using Data;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/notes")]
    public class NotesController:ControllerBase
    {
        private readonly AppDbContext _context;

        public NotesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllNotesAsync()
        {
            return Ok(

                await _context.Notes.ToListAsync()
            );
        }

        [HttpPost("create-one-note")]
        public async Task<IActionResult> CreateOneNoteAsync(CreateNoteDto createNoteDto)
        {
            var note=new Note()
            {
                AuthorName=createNoteDto.AuthorName,
                CreatedDate=default,
                Description=createNoteDto.Description,
                Name=createNoteDto.Name,
                Nickname=createNoteDto.Nickname,
                Surname=createNoteDto.Surname                
            };
            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();
            return Created();

        }
    }
}