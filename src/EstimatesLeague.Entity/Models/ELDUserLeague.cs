using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EstimatesLeague.Entity
{
    [Table("UserLeague")]
    public class ELDUserLeague
    {
        [Key]
        public Guid UserLeagueId { get; set; }
        public Guid LeagueId { get; set; }
        public string LeagueName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}