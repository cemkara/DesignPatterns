using DDD_DomainDriven.Repositories;
using DDD_DomainDriven.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD_DomainDriven.Controllers
{
    public class ParcelController : Controller
    {
        private readonly TrackingService _trackingService;
        private readonly ParcelRepository _parcelRepository;

        public ParcelController(TrackingService trackingService, ParcelRepository parcelRepository)
        {
            _trackingService = trackingService;
            _parcelRepository = parcelRepository;
        }

        public async Task<IActionResult> Index()
        {
            var parcels = await _parcelRepository.GetAllParcelsAsync();
            return View(parcels);
        }

        [HttpGet]
        public IActionResult TrackParcel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TrackParcel(string trackingNumber)
        {
            var parcel = await _trackingService.TrackParcelAsync(trackingNumber);
            if (parcel != null)
            {
                return View("ParcelDetails", parcel);
            }
            return View("Error");
        }

    }
}
