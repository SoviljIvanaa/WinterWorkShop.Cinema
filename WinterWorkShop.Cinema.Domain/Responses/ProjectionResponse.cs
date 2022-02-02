using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class ProjectionResponse
    {
        public int Id { get; set; }
        public DateTime ProjectionDate { get; set; }
        public string ProjectionName { get; set; }
    }
}
