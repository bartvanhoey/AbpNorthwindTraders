using System;
using System.Threading.Tasks;
using AbpNorthwindTraders.Domain;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace AbpNorthwindTraders.EntityFrameworkCore.Domain
{
    public class EmployeeRepositoryTests : AbpNorthwindTradersEntityFrameworkCoreTestBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeRepositoryTests()
        {
            _employeeRepository = GetRequiredService<IEmployeeRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
