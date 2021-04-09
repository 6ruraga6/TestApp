using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegCount
    {
        public DateTime RegDate { get; set; }
        public int Count { get; set; }
    }

    public class DateDiffCount
    {
        public DateTime RegDate { get; set; }
        public int DateDiff { get; set; }
        public int Count { get; set; }
    }

    public class RollingRetentionItem
    {
        public int DateDiff { get; set; }
        public int Days { get; set; }
        public int RetentionBase { get; set; }
        public int RetentionRate { get; set; }
    }
}
