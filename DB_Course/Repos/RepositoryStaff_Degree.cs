﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Npgsql;
using DB_Course.Tables;

namespace DB_Course.Repos
{
    class RepositoryStaff_Degree
    {
        private SqlConnection sqlConnection;
        public RepositoryStaff_Degree(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
    }
}