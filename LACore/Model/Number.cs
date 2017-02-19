using LACore.Common;
using System;
using System.Collections.Generic;

namespace LACore.Model
{
    public partial class Number:Entity
    {
        public int Number1 { get; set; }
        public bool? IsSpecial { get; set; }
        public int? NotSeen { get; set; }
        public int? Occurencies { get; set; }
    }
}
