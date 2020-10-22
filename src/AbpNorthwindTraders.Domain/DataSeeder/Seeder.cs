using System.Threading.Tasks;
using AbpNorthwindTraders.Domain.DataSeeder.Data;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpNorthwindTraders.Domain.DataSeeder
{
  public class Seeder : IDataSeedContributor, ITransientDependency
  {
    private readonly IRepository<Employee, int> _employeeRepository;
    private readonly IRepository<Region, int> _regionRepository;
    private readonly IRepository<Territory, string> _territoryRepository;
    private readonly IRepository<Customer, string> _customerRepository;
    private readonly IRepository<Supplier, int> _supplierRepository;
    private readonly IRepository<Category, int> _categoryRepository;
    private readonly IRepository<Product, int> _productRepository;
    private readonly IRepository<Shipper, int> _shipperRepository;
    private readonly IRepository<Order, int> _orderRepository;

    public Seeder(IRepository<Employee, int> employeeRepository, IRepository<Region, int> regionRepository, IRepository<Territory, string> territoryRepository, IRepository<Customer, string> customerRepository, IRepository<Supplier, int> supplierRepository, IRepository<Category, int> categoryRepository, IRepository<Product, int> productRepository, IRepository<Shipper, int> shipperRepository, IRepository<Order, int> orderRepository)
    {
      _employeeRepository = employeeRepository;
      _regionRepository = regionRepository;
      _territoryRepository = territoryRepository;
      _customerRepository = customerRepository;
      _supplierRepository = supplierRepository;
      _categoryRepository = categoryRepository;
      _productRepository = productRepository;
      _shipperRepository = shipperRepository;
      _orderRepository = orderRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
      //  Seed Regions
      if (await _regionRepository.GetCountAsync() <= 0)
      {
        var regions = RegionData.GetRegions();
        foreach (var region in regions)
        {
          await _regionRepository.InsertAsync(region);
        }
      }

      //   Seed Territories
      if (await _regionRepository.GetCountAsync() <= 0)
      {
        TerritoryData.AddTerritories();
        foreach (var territory in TerritoryData.Territories)
        {
          await _territoryRepository.InsertAsync(territory);
        }
      }

      // Seed Employees
      if (await _employeeRepository.GetCountAsync() <= 0)
      {
        var employees = EmployeeData.GetEmployees().Values;
        foreach (var employee in employees)
        {
          await _employeeRepository.InsertAsync(employee);
        }
      }

      // Seed Customers
      if (await _customerRepository.GetCountAsync() <= 0)
      {
        var customers = CustomerData.GetCustomers();
        foreach (var customer in customers)
        {
          await _customerRepository.InsertAsync(customer);
        }
      }

      // Seed Suppliers
      if (await _supplierRepository.GetCountAsync() <= 0)
      {
        var suppliers = SupplierData.GetSuppliers().Values;
        foreach (var supplier in suppliers)
        {
          await _supplierRepository.InsertAsync(supplier);
        }
      }

      // Seed Categories
      if (await _categoryRepository.GetCountAsync() <= 0)
      {
        var categories = CategoryData.GetCategories().Values;
        foreach (var category in categories)
        {
          await _categoryRepository.InsertAsync(category);
        }
      }

      // Seed Products
      if (await _productRepository.GetCountAsync() <= 0)
      {
        var products = ProductData.GetProducts().Values;
        foreach (var product in products)
        {
          await _productRepository.InsertAsync(product);
        }
      }

      // Seed Shippers
      if (await _shipperRepository.GetCountAsync() <= 0)
      {
        var shippers = ShipperData.GetShippers().Values;
        foreach (var shipper in shippers)
        {
          await _shipperRepository.InsertAsync(shipper);
        }
      }

       // Seed Orders
      if (await _orderRepository.GetCountAsync() <= 0)
      {
        var orders = OrderData.GetOrders();
        foreach (var order in orders)
        {
          await _orderRepository.InsertAsync(order);
        }
      }

    }
  }
}