using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideEdgeModels.BlazorModels
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public int Quantity{ get; set; }

        public double Price { get; set; }

        public bool IsAvailable { get; set; }

        public string? Body { get; set; }
        public string? Neck { get; set; }
        public string? Color { get; set; }

    }
}
