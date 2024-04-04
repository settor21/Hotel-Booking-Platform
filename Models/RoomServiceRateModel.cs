// RoomServiceRateModel.cs
namespace PricingAdmin.Models
{
    public class RoomServiceRateModel
    {
        public int RoomServiceRateID { get; set; }
        public string RoomServiceType { get; set; }
        public decimal Rate { get; set; }

        // Constructor
        public RoomServiceRateModel()
        {
            RoomServiceType = ""; // Initialize RoomServiceType
        }
    }
}
