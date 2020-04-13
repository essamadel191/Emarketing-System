using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Phase_1.Models.ProjectModels
{    
    public class Category
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Number_of_products { get; set; }
        
        public ICollection<Product> products { get; set; }
    }
}