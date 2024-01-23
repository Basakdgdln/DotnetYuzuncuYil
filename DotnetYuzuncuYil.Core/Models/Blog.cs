using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class Blog : BaseEntity
    {
        public string BlogContent { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int WriterID { get; set; }
        public Writer Writer { get; set; }

    }
}
