using AbpNorthwindTraders.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpNorthwindTraders.Permissions
{
    public class AbpNorthwindTradersPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpNorthwindTradersPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpNorthwindTradersPermissions.MyPermission1, L("Permission:MyPermission1"));

            var regionPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Region.Default, L("Permission:Region"));
            regionPermission.AddChild(AbpNorthwindTradersPermissions.Region.Create, L("Permission:Create"));
            regionPermission.AddChild(AbpNorthwindTradersPermissions.Region.Update, L("Permission:Update"));
            regionPermission.AddChild(AbpNorthwindTradersPermissions.Region.Delete, L("Permission:Delete"));

            var territoryPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Territory.Default, L("Permission:Territory"));
            territoryPermission.AddChild(AbpNorthwindTradersPermissions.Territory.Create, L("Permission:Create"));
            territoryPermission.AddChild(AbpNorthwindTradersPermissions.Territory.Update, L("Permission:Update"));
            territoryPermission.AddChild(AbpNorthwindTradersPermissions.Territory.Delete, L("Permission:Delete"));

            var employeePermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Employee.Default, L("Permission:Employee"));
            employeePermission.AddChild(AbpNorthwindTradersPermissions.Employee.Create, L("Permission:Create"));
            employeePermission.AddChild(AbpNorthwindTradersPermissions.Employee.Update, L("Permission:Update"));
            employeePermission.AddChild(AbpNorthwindTradersPermissions.Employee.Delete, L("Permission:Delete"));

            var customerPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Customer.Default, L("Permission:Customer"));
            customerPermission.AddChild(AbpNorthwindTradersPermissions.Customer.Create, L("Permission:Create"));
            customerPermission.AddChild(AbpNorthwindTradersPermissions.Customer.Update, L("Permission:Update"));
            customerPermission.AddChild(AbpNorthwindTradersPermissions.Customer.Delete, L("Permission:Delete"));

            var supplierPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Supplier.Default, L("Permission:Supplier"));
            supplierPermission.AddChild(AbpNorthwindTradersPermissions.Supplier.Create, L("Permission:Create"));
            supplierPermission.AddChild(AbpNorthwindTradersPermissions.Supplier.Update, L("Permission:Update"));
            supplierPermission.AddChild(AbpNorthwindTradersPermissions.Supplier.Delete, L("Permission:Delete"));

            var categoryPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Category.Default, L("Permission:Category"));
            categoryPermission.AddChild(AbpNorthwindTradersPermissions.Category.Create, L("Permission:Create"));
            categoryPermission.AddChild(AbpNorthwindTradersPermissions.Category.Update, L("Permission:Update"));
            categoryPermission.AddChild(AbpNorthwindTradersPermissions.Category.Delete, L("Permission:Delete"));

            var productPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Product.Default, L("Permission:Product"));
            productPermission.AddChild(AbpNorthwindTradersPermissions.Product.Create, L("Permission:Create"));
            productPermission.AddChild(AbpNorthwindTradersPermissions.Product.Update, L("Permission:Update"));
            productPermission.AddChild(AbpNorthwindTradersPermissions.Product.Delete, L("Permission:Delete"));

            var shipperPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Shipper.Default, L("Permission:Shipper"));
            shipperPermission.AddChild(AbpNorthwindTradersPermissions.Shipper.Create, L("Permission:Create"));
            shipperPermission.AddChild(AbpNorthwindTradersPermissions.Shipper.Update, L("Permission:Update"));
            shipperPermission.AddChild(AbpNorthwindTradersPermissions.Shipper.Delete, L("Permission:Delete"));

            var orderPermission = myGroup.AddPermission(AbpNorthwindTradersPermissions.Order.Default, L("Permission:Order"));
            orderPermission.AddChild(AbpNorthwindTradersPermissions.Order.Create, L("Permission:Create"));
            orderPermission.AddChild(AbpNorthwindTradersPermissions.Order.Update, L("Permission:Update"));
            orderPermission.AddChild(AbpNorthwindTradersPermissions.Order.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpNorthwindTradersResource>(name);
        }
    }
}
