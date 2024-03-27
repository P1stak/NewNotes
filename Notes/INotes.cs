using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public interface INotes
    {
        void Show();
        void Insert(int id, string name, string text, DateTime date);
        void Insert(string name, string text, DateTime date);
        void Insert(int id, string name, DateTime date);
        void Insert(string name, DateTime date);
        void Insert(int id, string name);
        void Insert(int id, string name, string text);
        void Update(int Id, string name, DateTime date);
        void Update(int Id, string name);
        void Update(int Id, string name, string text);
        void Update(int Id, string name, string text, DateTime date);
        void Delete(int Id);
    }
}
