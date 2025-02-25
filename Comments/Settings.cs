﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    record MongoDBSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }

    record Settings
    {
        public MongoDBSettings MongoDBSettings { get; set; }

        public string UserAgent { get; set; }
    }
}