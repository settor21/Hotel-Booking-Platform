using System.Collections.Generic;
using PricingAdmin.Models;
using PricingAdmin.Services;

namespace PricingAdmin.ViewModels
{
    public class RoomTypeRateViewModel : ViewModelBase
    {
        private readonly GetRates _getRatesService;
        private readonly SetNewRates _setNewRatesService;
        private readonly UpdateExistingRates _updateExistingRatesService;
        private readonly DeleteRates _deleteRatesService;

        public List<RoomTypeRateModel> RoomTypeRates { get; private set; }

        public RoomTypeRateViewModel()
        {
            _getRatesService = new GetRates();
            _setNewRatesService = new SetNewRates();
            _updateExistingRatesService = new UpdateExistingRates();
            _deleteRatesService = new DeleteRates();

            // Initialize RoomTypeRates
            RoomTypeRates = _getRatesService.GetRoomTypeRates();
        }

        // Methods for CRUD operations
        public void AddRoomTypeRate(RoomTypeRateModel rate)
        {
            _setNewRatesService.AddRoomTypeRate(rate);
            RoomTypeRates = _getRatesService.GetRoomTypeRates(); // Refresh rates
        }

        public void UpdateRoomTypeRate(RoomTypeRateModel rate)
        {
            _updateExistingRatesService.UpdateRoomTypeRate(rate);
            RoomTypeRates = _getRatesService.GetRoomTypeRates(); // Refresh rates
        }

        public void DeleteRoomTypeRate(int rateId)
        {
            _deleteRatesService.DeleteRoomTypeRate(rateId);
            RoomTypeRates = _getRatesService.GetRoomTypeRates(); // Refresh rates
        }
    }
}
