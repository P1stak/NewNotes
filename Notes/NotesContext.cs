using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

namespace Notes
{
    class NotesContext : DbContext, INotes
    {
        public NotesContext() : base("DbConnection")
        {
            Console.WriteLine("Done");
        }
        public bool IsValid(string name)
        {
            if (name.Length <= 15 && name.StartsWith("Note"))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        public DbSet<Notes> Notes { get; set; } //создали таблицу
        public void Show()
        {
            foreach (var note in Notes)
            {
                Console.WriteLine($"{note.Id} {note.Name} {note.Text} {note.Date}");
            }
        }
        public void Insert(int id, string name, string text, DateTime date) //id, name, text, data
        {
            if (!IsValid(name))
            {
                return;
            }
            Notes.Add(new Notes
            {
                Id = id,
                Name = name,
                Text = text,
                Date = date
            });
            SaveChanges();
        }
        public void Insert(string name, string text, DateTime date) //name, text, data
        {
            if (!IsValid(name))
            {
                return;
            }
            Notes.Add(new Notes 
            {
                Name = name,
                Text = text,
                Date = date
            });
            SaveChanges();
        }
        public void Insert(int id, string name, DateTime date) //id, name, data
        {
            Notes.Add(new Notes
            {
                Id = id,
                Name = name,
                Date = date
            });
            SaveChanges();
        }
        public void Insert(string name, DateTime date) //name, data
        {
            Notes.Add(new Notes
            {
                Name = name,
                Date = date
            });
            SaveChanges();
        }
        public void Insert(int id, string name) //Id, name
        {
            if (!IsValid(name))
            {
                return;
            }
            Notes.Add(new Notes
            {
                Id=id,
                Name = name
            });
            SaveChanges();
        }
        public void Insert(int id, string name, string text) //Id, name
        {
            if (!IsValid(name))
            {
                return;
            }
            Notes.Add(new Notes
            {
                Id = id,
                Name = name,
                Text = text
            });
            SaveChanges();
        }

        public void Update(int Id, string name, DateTime date)
        {
            Notes n = Notes.FirstOrDefault(f => f.Id == Id);
            if (n != null)
            {
                n.Name = name;
                n.Date = date;
            }
            else
            {
                Insert(Id, name, date);
            }
            SaveChanges();
        }

        public void Update(int Id, string name)
        {
            Notes n = Notes.FirstOrDefault(f => f.Id == Id);
            if (n != null)
            {
                n.Id = Id;
                n.Name = name;
            }
            else
            {
                Insert(Id, name);
            }
            SaveChanges();
        }

        public void Update(int Id, string name, string text)
        {
            Notes n = Notes.FirstOrDefault(f => f.Id == Id);
            if (n != null)
            {
                n.Id = Id;
                n.Name = name;
                n.Text = text;
            }
            else
            {
                Insert(Id, name, text);
            }
            SaveChanges();
        }

        public void Update(int Id, string name, string text, DateTime date)
        {
            Notes n = Notes.FirstOrDefault(f => f.Id == Id);
            if (n != null)
            {
                n.Id = Id;
                n.Name = name;
                n.Text = text;
                n.Date = date;
            }
            else
            {
                Insert(Id, name, text, date);
            }
            SaveChanges();
        }

        public void Delete(int Id)
        {
            Notes n = Notes.FirstOrDefault(f => f.Id == Id);
            if (n != null)
            {
                Notes.Remove(n);
            }
            SaveChanges();
        }
    }
}
