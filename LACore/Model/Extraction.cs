using LACore.Common;
using System;
using System.Collections.Generic;

namespace LACore.Model
{
    public partial class Extraction : Entity
    {
        public Extraction()
        {
            Factor = new HashSet<Factor>();
        }

        public DateTime ExtractionDate { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public int Number5 { get; set; }
        public int Number6 { get; set; }
        public int SpecialNumber { get; set; }

        public virtual ICollection<Factor> Factor { get; set; }
    }
}
