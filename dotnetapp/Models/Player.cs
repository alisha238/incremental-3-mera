using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class Player
    {
        [required]
        public int Id{get; set;}
        public int Id {get;set;}
            [Required(ErrorMessage = "Name is required.")]
            public string Name {get;set;}
            public int Age {get;set;}
            public string Category {get;set;}
            [Range(1, int.MaxValue, ErrorMessage = "Bidding amount must be greater than 0.")]
           
            public decimal BiddingAmount {get;set;}  
 
            public int TeamId {get;set;}
 
            public virtual Team team {get;set;}
    }
}