using System.Collections.Generic;
using PricingAdmin.Models;
using PricingAdmin.Services;

namespace PricingAdmin.ViewModels
{
    public class OccupantRateViewModel : ViewModelBase
    {
        private readonly GetRates _getRatesService;
        private readonly SetNewRates _setNewRatesService;
        private readonly UpdateExistingRates _updateExistingRatesService;
        private readonly DeleteRates _deleteRatesService;

        public List<OccupantRateModel> OccupantRates { get; private set; }

        public OccupantRateViewModel()
        {
            _getRatesService = new GetRates();
            _setNewRatesService = new SetNewRates();
            _updateExistingRatesService = new UpdateExistingRates();
            _deleteRatesService = new DeleteRates();

            // Initialize OccupantRates
            OccupantRates = _getRatesService.GetOccupantRates();
        }

        // Methods for CRUD operations
        public void AddOccupantRate(OccupantRateModel rate)
        {
            _setNewRatesService.AddOccupantRate(rate);
            OccupantRates = _getRatesService.GetOccupantRates(); // Refresh rates
        }

        public void UpdateOccupantRate(OccupantRateModel rate)
        {
            _updateExistingRatesService.UpdateOccupantRate(rate);
            OccupantRates = _getRatesService.GetOccupantRates(); // Refresh rates
        }

        public void DeleteOccupantRate(int rateId)
        {
            _deleteRatesService.DeleteOccupantRate(rateId);
            OccupantRates = _getRatesService.GetOccupantRates(); // Refresh rates
        }
    }
}
