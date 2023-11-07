﻿using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        public double Price {  get; set; }
        public string ImageURL {  get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public  MovieCategory MovieCategory   { get; set; }
        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set;}

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }


    }
}
