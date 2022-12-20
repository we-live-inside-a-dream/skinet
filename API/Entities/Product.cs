using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
// Entities is responsible to make connection with the database.
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}