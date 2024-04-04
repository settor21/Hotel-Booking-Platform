using System.Collections.Generic;
using PricingAdmin.Models;

namespace PricingAdmin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // Instantiate ViewModels for each model
        public RoomTypeRateViewModel RoomTypeRateViewModel { get; }
        public OccupantRateViewModel OccupantRateViewModel { get; }
        public RoomServiceRateViewModel RoomServiceRateViewModel { get; }

        public MainWindowViewModel()
        {
            // Initialize ViewModels
            RoomTypeRateViewModel = new RoomTypeRateViewModel();
            OccupantRateViewModel = new OccupantRateViewModel();
            RoomServiceRateViewModel = new RoomServiceRateViewModel();
        }
    }
}
