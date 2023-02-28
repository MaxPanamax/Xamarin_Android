using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Xamarin_Android_Lis_13_SQL.Models
{
    internal class Note
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
