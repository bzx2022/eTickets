using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster")]
        [Required(ErrorMessage = "Movie Poster URL is Required")]
        public string ImageUrl { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is Required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select Category")]
        [Required(ErrorMessage = "Movie Category is Required")]
        public MovieCategory MovieCategory { get; set; }

        //relationships
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Movie Actor(s) is Required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "Movie Cinema is Required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Movie producer is Required")]
        public int ProducerId { get; set; }


    }
}
