﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HardwareStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; } = "";
        
        [MaxLength(100)]
        public string Brand { get; set; } = "";
        
        [MaxLength(100)]
        public string Adress { get; set; } = "";
        
        [Precision(16,2)]
        public decimal Price { get; set; }
        
        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
        public DateTime BoughtAt {get; set; }
    }
}
