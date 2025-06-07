using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using LibraryApi.Models;
using LibraryApi.Data;

namespace LibraryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryContext _context;

        public LibraryController(LibraryContext context)
        {
            _context = context;
        }
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAll()
        {
            var books = await _context.Books.ToListAsync();
            return Ok(books);
        }
        [HttpGet("getbyid{Id}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBookById(int Id)
        {
            var book = _context.Books.Any(u => u.Id == Id);
            return Ok(book);
        }
        [HttpPost("create")]
        public async Task<ActionResult<Book>> PostCreateNew(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpPost("update")]
        public async Task<ActionResult<Book>> PostUpdate(Book book)
        {
            _context.Books.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpDelete("delete{Id}")]
        public async Task<ActionResult<bool>> Deletebook(int Id)
        {
            var book = _context.Books.Find(Id);
            var isdeleted = _context.Books.Remove(book);
            return Ok(isdeleted);
        }

        //  Retrieve a list of all books.
        // Retrieve a specific book by its ID.
        // Create a new book with an associated author.
        // Update an existing book's details.
        // Delete a book.
        // For the purpose of this exercise, you can assume that a Book has the following properties:
        // BookId: An integer that uniquely identifies the book.
        // Title: A string that holds the title of the book.
        // Author: An instance of an Author class.
        // Genre: A string that represents the genre of the book.
        // And an Author has these properties:
        // AuthorId: An integer that uniquely identifies the author.
        // Name: A string that represents the name of the author.





    }
}