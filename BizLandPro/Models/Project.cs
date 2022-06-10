using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLandPro.Models
{
    public class Project:BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public int ProjectCategoryId { get; set; }
        public ProjectCategory ProjectCategory { get; set; }



    }
}
