using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class City
    {
        [Key]
        public int cityId { get; set; }

        public string cityName { get; set; }
    }
}
