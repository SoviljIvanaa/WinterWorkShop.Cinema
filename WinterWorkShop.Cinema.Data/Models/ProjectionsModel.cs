using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Data.Models
{
    public class ProjectionsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
    }
}
