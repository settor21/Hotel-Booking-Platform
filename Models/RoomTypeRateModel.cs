// RoomTypeRateModel.cs
namespace PricingAdmin.Models
{
    public class RoomTypeRateModel
    {
        public int RateID { get; set; }
        public string RoomType { get; set; }
        public decimal Rate { get; set; }

        // Constructor
        public RoomTypeRateModel()
        {
            RoomType = ""; // Initialize RoomType
        }
    }
}
