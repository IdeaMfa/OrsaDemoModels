using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrsaDemoModels.Entity
{
    public class PersonnelInstitutionMediaRelation
    {

        [Key]
        public int TableId { get; set; }
        public int PersonnelTableId { get; set; }
        public int InstitutionId {  get; set; }
        public int InstitutionNumber { get; set; }
        public int MediaId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
