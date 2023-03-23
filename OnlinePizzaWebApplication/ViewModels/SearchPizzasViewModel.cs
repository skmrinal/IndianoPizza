﻿using IndianoPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianoPizza.ViewModels
{
    public class SearchPizzasViewModel
    {
        [Required]
        [DisplayName("Serach")]
        public string SearchText { get; set; }

        //public IEnumerable<string> SearchListExamples { get; set; }

        public IEnumerable<Pizzas> PizzaList { get; set; }

    }
}
