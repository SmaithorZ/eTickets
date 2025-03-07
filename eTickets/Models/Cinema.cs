﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {

        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Image")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Cinema Description")]
        public string Description { get; set; }


        //Relationships
        public List<Movie>Movies { get; set; }
    }
}
