using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Models
{
    public class Team
    {
        [Key]
        public int TeamId{get; set;}
        public string TeamName {get; set;}
        public ICollection<Player> ?Players {get; set;}
    }
}