using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Phase_1.Models.ProjectModels
{
    public class Product
    {
         
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
        
        public string Image { get; set; }

        public string Description { get; set; }
            
        public Category Category { get; set; }
    }
}