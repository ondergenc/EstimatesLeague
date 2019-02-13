using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EstimatesLeague.Entity
{
    [Table("League")]
    public class ELDLeague
    {
        [Key]
        public Guid LeagueId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Name { get; set; }
        public Guid CountryId { get; set; }


    }
}