using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Data.Aggregate.Common
{
    public class ItemData
    {
        public string Id { get; set; }

        public string Aggregate { get; set; }

        public int Version { get; set; }
    }
}
