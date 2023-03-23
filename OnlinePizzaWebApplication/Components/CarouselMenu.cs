using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndianoPizza.Data;
using IndianoPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianoPizza.Components
{
    public class CarouselMenu : ViewComponent
    {
        private readonly AppDbContext _context;
        public CarouselMenu(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pizzas = await _context.Pizzas.Where(x => x.IsPizzaOfTheWeek).ToListAsync();
            return View(pizzas);
        }
    }
}
