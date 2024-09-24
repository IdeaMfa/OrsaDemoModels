using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsaDemoModels.Entity
{
    public class MediaLibrary
    {

        [Key]
        public long Id { get; set; }
        public string MediaName { get; set; } = null;
        public string MediaUrl { get; set; } = null;

    }
}
