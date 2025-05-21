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
                notes.Insert(1, "One");
                notes.Insert(2, "Two", DateTime.Now);
                notes.Insert("Three", DateTime.Now);
                notes.Insert("bla-bla-bla", DateTime.Now);
                notes.Update(2, "ThReE");
                notes.Show();

                // test
                // test 123
            }
        }
    }
}
