using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
 
namespace dotnetapp.Models
{
    public class Player
        {
            [Required]
            public int Id {get;set;}
            [Required(ErrorMessage = "Name is required.")]
            public string Name {get;set;}
            public int Age {get;set;}
            public string Category {get;set;}
            [Range(1, int.MaxValue, ErrorMessage = "Bidding price must be greater than 0.")]
           
            public decimal BiddingPrice {get;set;}  
            [ForeignKey("Team")]
 
            public int TeamId {get;set;}
 
            public virtual Team ?team {get;set;}
        }
}