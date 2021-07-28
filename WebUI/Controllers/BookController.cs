using Business.Abstract;
using DataAccess.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class BookController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IReservationService _reservationService;
        public BookController(ICountryService countryService,IReservationService reservationService)
        {
            _countryService = countryService;
            _reservationService = reservationService;
        }

        public IActionResult Reservation()
        {
            var result = _countryService.GetList();
            BookCheckOutViewModel model = new BookCheckOutViewModel
            {
                Countries = result,
                CheckOutDate = DateTime.Now,
                ReturnedDate = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Reservation(BookCheckOutFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _reservationService.GetReservationInfo(model.CheckOutDate, model.ReturnedDate, model.CountryId);

            var resultViewModel = new BookResultViewModel
            {
                ReservationResult = result
            };

            return View("Result", resultViewModel);
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
