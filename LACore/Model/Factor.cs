using LACore.Common;
using System;
using System.Collections.Generic;

namespace LACore.Model
{
    public partial class Factor:Entity
    {
        public decimal Factor1 { get; set; }
        public decimal Factor2 { get; set; }
        public int ExtractionId { get; set; }

        public virtual Extraction Extraction { get; set; }
    }
}
