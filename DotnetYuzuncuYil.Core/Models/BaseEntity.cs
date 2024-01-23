using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate;

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
