using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Data.Models
{
    public class ProjectionModel
    {
        public int Id { get; set; }
        public DateTime ProjectionDate { get; set;}
        public string ProjectionName { get; set;}

        public int MovieId { get; set; }
    }
}
