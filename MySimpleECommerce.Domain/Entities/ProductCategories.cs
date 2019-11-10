using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleECommerce.Domain.Entities
{
    public class ProductCategories : Base
    {
        public string KeyWord { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
