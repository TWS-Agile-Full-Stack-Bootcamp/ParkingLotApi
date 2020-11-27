using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    [Table("ParkingBoy")]
    public class ParkingBoy
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    [Table("SmartParkingBoy")]
    public class SmartParkingBoy : ParkingBoy
    {
    }
}