﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Course.Tables
{
    class Positions
    {
        public string ID_Position { private set; get; }
        public string Name { private set; get; }

        public Positions () { }

        public Positions(
            string ID_Position,
            string Name)
        {
            this.ID_Position = ID_Position;
            this.Name = Name;
        }
    }
}