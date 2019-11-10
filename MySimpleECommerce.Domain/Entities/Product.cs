using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleECommerce.Domain.Entities
{
    public class Product : Base
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Price { get; set; }
        public virtual ProductCategories Categories { get; set; }
    }
}
