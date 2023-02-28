using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin_Android_Lis_13_SQL.Models;

namespace Xamarin_Android_Lis_13_SQL.Date
{
    internal class NoteDB
    {
        readonly SQLiteAsyncConnection _connection;
        public NoteDB(string connectiongString)
        {
            _connection=new SQLiteAsyncConnection(connectiongString);
            _connection.CreateTableAsync<Note>().Wait();
        }
        public Task<List<Note>>GetNotesAsync()
        {
            return _connection.Table<Note>().ToListAsync();
        }
        public Task<Note> GetNoteByIdAsync(int id)
        {
            return _connection.Table<Note>() .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public Task<int>SaveNoteAsync(Note note)
        {
            if(note.Id!=0)
            {
                return _connection.UpdateAsync(note);
            }
            else
            {
                return _connection.InsertAsync(note);
            }
        }
        public Task<int>DeleteNoteAsync(Note note)
        {
            return _connection.DeleteAsync(note);
        }
    }
} 
