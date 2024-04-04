// OccupantRateModel.cs
namespace PricingAdmin.Models
{
    public class OccupantRateModel
    {
        public int OccupantRateID { get; set; }
        public int NumberOfOccupants { get; set; }
        public decimal Rate { get; set; }

        // Constructor
        public OccupantRateModel()
        {
            NumberOfOccupants = 0; // Initialize NumberOfOccupants
        }
    }
}

