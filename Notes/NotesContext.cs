using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Notes
{
    class NotesContext : DbContext
    {
        public NotesContext() : base("DbConnection")
        {
            Console.WriteLine("Done");
        }
        public DbSet<Notes> Notes { get; set; } //создали таблицу
        public void Show()
        {
            foreach (var note in Notes)
            {
                Console.WriteLine($"{note.Id} {note.Name} {note.Text} {note.Date}");
            }
        }
        public void Insert(string name, string text, DateTime date)
        {
            Notes.Add(new Notes 
            {
                Name = name,
                Text = text,
                Date = date
            });
            SaveChanges();
        }
    }
}
