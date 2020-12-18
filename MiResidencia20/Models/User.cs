using System;
using SQLite;
namespace MiResidencia20.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Career { get; set; }
        public string Group { get; set; }
        public string Period { get; set; }

    }
}
