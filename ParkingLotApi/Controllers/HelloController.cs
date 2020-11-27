using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkingLotApi.Repository;

namespace ParkingLotApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly ParkingLotContext parkingLotContext;

        public HelloController(ParkingLotContext parkingLotContext)
        {
            this.parkingLotContext = parkingLotContext;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var boy = new ParkingBoy()
            {
                Name = "ParkingBoy"
            };

            var smartBoy = new SmartParkingBoy()
            {
                Name = "SmartParkingBoy"
            };

            await parkingLotContext.ParkingBoys.AddAsync(boy);
            await parkingLotContext.SmartParkingBoys.AddRangeAsync(smartBoy);
            await parkingLotContext.SaveChangesAsync();

            return "Hello world";
        }
    }
}