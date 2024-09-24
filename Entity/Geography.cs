using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsaDemoModels.Entity
{
    public class Geography
    {
        [Key]
        public int Id { get; set; }
        public string RegionName { get; set; }
        public int? ParentId { get; set; }

    }
}
