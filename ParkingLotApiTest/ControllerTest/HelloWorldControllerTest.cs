using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParkingLotApi;
using ParkingLotApi.Repository;
using Xunit;

namespace ParkingLotApiTest.ControllerTest
{
    public class HelloWorldControllerTest : TestBase
    {
        public HelloWorldControllerTest(CustomWebApplicationFactory<Startup> factory) : base(factory)
        {
        }

        [Fact]
        public async Task Should_get_hello_world()
        {
            var client = GetClient();

            var allCompaniesResponse = await client.GetAsync("/Hello");
            var responseBody = await allCompaniesResponse.Content.ReadAsStringAsync();

            Assert.Equal("Hello World", responseBody);
        }

        [Fact]
        public async Task Should_delete_company_and_related_profile_employee_success_via_company_service()
        {
            var scope = Factory.Services.CreateScope();
            var scopedServices = scope.ServiceProvider;

            ParkingLotContext context = scopedServices.GetRequiredService<ParkingLotContext>();
            Company company = new Company()
            {
                Name = "Tom"
            };

            await context.Companies.AddAsync(company);
            await context.SaveChangesAsync();

            var allCompanies = await context.Companies.ToListAsync();
            Assert.Equal(1, allCompanies.Count);
        }
    }
}