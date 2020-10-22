namespace AbpNorthwindTraders.Permissions
{
    public static class AbpNorthwindTradersPermissions
    {
        public const string GroupName = "AbpNorthwindTraders";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Region
        {
            public const string Default = GroupName + ".Region";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Territory
        {
            public const string Default = GroupName + ".Territory";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Employee
        {
            public const string Default = GroupName + ".Employee";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Customer
        {
            public const string Default = GroupName + ".Customer";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Supplier
        {
            public const string Default = GroupName + ".Supplier";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Category
        {
            public const string Default = GroupName + ".Category";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Product
        {
            public const string Default = GroupName + ".Product";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Shipper
        {
            public const string Default = GroupName + ".Shipper";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Order
        {
            public const string Default = GroupName + ".Order";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
