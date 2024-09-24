using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsaDemoModels.Entity
{
    public class PersonnelMedia
    {

        [Key]
        public long TableId { get; set; }
        public int PersonnelId { get; set; }
        public long MediaId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
