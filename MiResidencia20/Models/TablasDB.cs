using System;
using SQLite;
namespace MiResidencia20.Models
{
    public class TablasDB
    {
        public class Student
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Career   { get; set; }
            public string Group    { get; set; }
            public string Period   { get; set; }
            //public DateTime CreationDate { get; set; }
        }

        public class ResultEvaluation 
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
           // [Indexed]
            public int ResultUnit1 { get; set; }
            public int ResultUnit2 { get; set; }
            public int ResultUnit3 { get; set; }
            public int ResultUnit4 { get; set; }
            public int ResultUnit5 { get; set; }
            public int ResultUnit6 { get; set; }
            public int ResultUnit7 { get; set; }
            public int ResultUnit8 { get; set; }
            public int ResultUnit9 { get; set; }

        }

    }
}
