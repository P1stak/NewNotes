using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NotesContext notes = new NotesContext())
            {
                notes.Insert("Note1", "MyFirstNote", DateTime.Now);
                notes.Show();
            }
        }
    }
}
