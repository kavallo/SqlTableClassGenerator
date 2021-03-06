﻿using System.Collections.Generic;

namespace Models
{
    public class Database
    {
        public Database(string name, IEnumerable<Table> tables)
        {
            Name = name;
            Tables = tables;
        }

        public string Name { get; }

        public IEnumerable<Table> Tables { get; }
    }
}
