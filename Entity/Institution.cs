using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrsaDemoModels.Entity
{
    public class Institution
    {

        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public int GraduationYear { get; set; }
        public int PersonnelId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted{ get; set; }
        public int InstitutionNumber { get; set; }

    }
}
