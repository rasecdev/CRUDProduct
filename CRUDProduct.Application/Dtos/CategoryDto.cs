using CRUDProduct.Domain.Entities;
using System.Collections.Generic;

namespace CRUDProduct.Application.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}