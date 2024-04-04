using System.Collections.Generic;
using PricingAdmin.Models;
using PricingAdmin.Services;

namespace PricingAdmin.ViewModels
{
    public class RoomServiceRateViewModel : ViewModelBase
    {
        private readonly GetRates _getRatesService;
        private readonly SetNewRates _setNewRatesService;
        private readonly UpdateExistingRates _updateExistingRatesService;
        private readonly DeleteRates _deleteRatesService;

        public List<RoomServiceRateModel> RoomServiceRates { get; private set; }

        public RoomServiceRateViewModel()
        {
            _getRatesService = new GetRates();
            _setNewRatesService = new SetNewRates();
            _updateExistingRatesService = new UpdateExistingRates();
            _deleteRatesService = new DeleteRates();

            // Initialize RoomServiceRates
            RoomServiceRates = _getRatesService.GetRoomServiceRates();
        }

        // Methods for CRUD operations
        public void AddRoomServiceRate(RoomServiceRateModel rate)
        {
            _setNewRatesService.AddRoomServiceRate(rate);
            RoomServiceRates = _getRatesService.GetRoomServiceRates(); // Refresh rates
        }

        public void UpdateRoomServiceRate(RoomServiceRateModel rate)
        {
            _updateExistingRatesService.UpdateRoomServiceRate(rate);
            RoomServiceRates = _getRatesService.GetRoomServiceRates(); // Refresh rates
        }

        public void DeleteRoomServiceRate(int rateId)
        {
            _deleteRatesService.DeleteRoomServiceRate(rateId);
            RoomServiceRates = _getRatesService.GetRoomServiceRates(); // Refresh rates
        }
    }
}
