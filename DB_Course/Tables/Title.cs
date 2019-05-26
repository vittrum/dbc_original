﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Course.Tables
{
    class Title
    {
        public string ID_Title { private set; get; }
        public string Name { private set; get; }
        public Title() { }
        public Title(
            string ID_Title,
            string Name)
        {
            this.Name = Name;
            this.ID_Title = ID_Title;
        }
    }
}