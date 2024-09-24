using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsaDemoModels.Entity.VmModel
{
    public class vmPersonnelInstitutionData
    {

        public int InstitutionId { get; set; }
        public int InstitutionNumber { get; set; }
        public string InstitutionName { get; set; }
        public int GraduationYear { get; set; }
        public List<MediaLibrary>? InstitutionMediaLibrary { get; set; }

    }
}
