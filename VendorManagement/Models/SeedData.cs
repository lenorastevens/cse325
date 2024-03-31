using Microsoft.EntityFrameworkCore;
using VendorManagement.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VendorManagement.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VendorManagementContext(serviceProvider.GetRequiredService<DbContextOptions<VendorManagementContext>>()))
            {
                // Look for any movies.
                if (context.Vendors.Any())
                {
                    return;   // DB has been seeded
                }
                context.Vendors.AddRange(
                    new Vendors
                    {
                        Name = "ABC Gym",
                        Contact = "John Smith",
                        Position = "Sales Manager",
                        Phone = "123-456-7890",
                        Email = "john.smith@abccompany.com",
                        Address = "123 Main Street",
                        City = "Anytown",
                        State = "California",
                        ZipCode = 12345,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "XYZ Fitness",
                        Contact = "Sarah Johnson",
                        Position = "Marketing Director",
                        Phone = " 987-654-3210",
                        Email = "sarah.johnson@xyzcorp.com",
                        Address = "456 Oak Avenu",
                        City = "Smallville",
                        State = "Texas",
                        ZipCode = 54321,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "DEF Industries",
                        Contact = "Michael Brown",
                        Position = "Operations Manager",
                        Phone = "555-123-4567",
                        Email = "mbrown@defindustries.net",
                        Address = "789 Elm Street",
                        City = "Metropolis",
                        State = "New York",
                        ZipCode = 67890,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "LMN Enterprises",
                        Contact = "Emily Davis",
                        Position = "HR Coordinator",
                        Phone = "222-333-4444",
                        Email = "emily.davis@lmnent.com",
                        Address = "101 Pine Road",
                        City = "Springfield",
                        State = "Illinois",
                        ZipCode = 54321,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "PQR Corporation",
                        Contact = "David Lee",
                        Position = "Product Manager",
                        Phone = "999-888-7777",
                        Email = "david.lee@pqrcorp.com",
                        Address = "777 Cedar Lane",
                        City = "Rivertown",
                        State = "Florida",
                        ZipCode = 32198,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "Jessica Garcia",
                        Contact = "MNO Solutions",
                        Position = "Project Coordinator",
                        Phone = "777-666-5555",
                        Email = "jgarcia@mnosolutions.org",
                        Address = "222 Maple Avenue",
                        City = "Lakeside",
                        State = "Michigan",
                        ZipCode = 87654,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "GHI Health",
                        Contact = "Robert Clark",
                        Position = "Finance Manager",
                        Phone = "333-444-5555",
                        Email = "rclark@ghihealth.com",
                        Address = "444 Birch Street",
                        City = "Mountainview",
                        State = "Colorado",
                        ZipCode = 23456,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "UVW Corporation",
                        Contact = "Christopher Taylor",
                        Position = "Customer Service Representative",
                        Phone = "888-777-6666",
                        Email = "christaylor@uvwcorp.com",
                        Address = "999 Walnut Avenue",
                        City = "Seaview",
                        State = "Washington",
                        ZipCode = 34567,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "STU Solutions",
                        Contact = "Samantha White",
                        Position = "Product Manager",
                        Phone = "647-895-2155",
                        Email = "samwhite@stusolutions.com",
                        Address = "333 Pineapple Road",
                        City = "Sunnyside",
                        State = "California",
                        ZipCode = 12345,
                        Notes = []
                    },
                    new Vendors
                    {
                        Name = "RST Enterprises",
                        Contact = "Jennifer Martinez",
                        Position = "Marketing Coordinator",
                        Phone = "111-234-5177",
                        Email = "jmartinez@rstenterprises.org",
                        Address = "555 Orange Avenue",
                        City = "Hillside",
                        State = "New Jersey",
                        ZipCode = 56789,
                        Notes = []
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
