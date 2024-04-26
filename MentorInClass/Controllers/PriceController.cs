using MentorInClass.DAL;
using MentorInClass.Models;
using MentorInClass.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorInClass.Controllers
{
    public class PriceController : Controller
    {
        private readonly AppDbContext _context;

        public PriceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FeaRiceVM feaRiceVM = new FeaRiceVM()
            {
                Feature = _context.Features.Include(x=>x.Pricings).ToList(),

                Pricing = _context.Pricing.ToList(),
            };
            return View(feaRiceVM);
        }
    }
}
