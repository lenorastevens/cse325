using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ScriptureBook { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DateSort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";


            IQueryable<string> bookQuery = from s in _context.Scripture orderby s.Book select s.Book;

            var scriptures = from s in _context.Scripture select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Impression.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook)) 
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            scriptures = sortOrder switch
            {
                "book_desc" => scriptures.OrderByDescending(b => b.Book),
                "Date" => scriptures.OrderBy(d => d.EntryDate),
                "date_desc" => scriptures.OrderByDescending(d => d.EntryDate),
                _ => scriptures.OrderBy(b => b.Book),
            };
            Scripture = await scriptures.ToListAsync();

        }
    }
}
