using System;
using System.Linq;
using System.Web.Mvc;
using LiveMusicHub.Models;
using LiveMusicHub.ViewModels;
using Microsoft.AspNet.Identity;
<<<<<<< HEAD
using System;
=======
>>>>>>> Saving a Gig implemented, minor changes in database

namespace LiveMusicHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
<<<<<<< HEAD
            var userId = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == userId);
=======
>>>>>>> Saving a Gig implemented, minor changes in database
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            var gig = new Gig
            {
<<<<<<< HEAD
                ArtistId = arti
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venue = viewModel.Venue
            };
=======
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

>>>>>>> Saving a Gig implemented, minor changes in database
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}