using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsaDemoModels.Entity.VmModel
{
    public class vmListPersonnel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public List<MediaLibrary> MediaLibrary { get; set; }
        public vmPersonnelInstitution? PersonnelInstitution { get; set; }
        public List<vmPersonnelInstitutionData>? PersonnelInstitutions { get; set; }

    }
}
