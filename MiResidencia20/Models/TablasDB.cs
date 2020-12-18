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
            public string Career { get; set; }
            public string Group  { get; set; }
            public string Period { get; set; }
            //public DateTime CreationDate { get; set; }
        }

        public class ResultEvaluation 
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [Indexed]
            public int Unit1 { get; set; }
            public int Unit2 { get; set; }
            public int Unit3 { get; set; }
            public int Unit4 { get; set; }
            public int Unit5 { get; set; }
            public int Unit6 { get; set; }
            public int Unit7 { get; set; }
            public int Unit8 { get; set; }
            public int Unit9 { get; set; }

        }

    }
}
