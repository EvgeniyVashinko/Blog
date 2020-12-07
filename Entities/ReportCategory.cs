using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class ReportCategory
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string BeName { get; set; }
        public string EnName { get; set; }
        public List<Report> Reports { get; set; }

        public string GetLocalizedName(string langcode)
        {
            switch (langcode)
            {
                case "ru":
                    return Name;
                case "be":
                    return BeName;
                case "en":
                    return EnName;
                default:
                    return default;   
            }
        }
    }
}
