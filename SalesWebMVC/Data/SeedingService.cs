using Microsoft.EntityFrameworkCore.Internal;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department department1 = new Department("Computers");
            Department department2 = new Department("Electronics");
            Department department3 = new Department("Fashion");
            Department department4 = new Department("Books");

            Seller seller1 = new Seller("Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, department1);
            Seller seller2 = new Seller("Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, department2);
            Seller seller3 = new Seller("Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, department1);
            Seller seller4 = new Seller("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, department4);
            Seller seller5 = new Seller("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, department3);
            Seller seller6 = new Seller("Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, department2);

            SalesRecord saleRecord1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, seller1);
            SalesRecord saleRecord2 = new SalesRecord(new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, seller5);
            SalesRecord saleRecord3 = new SalesRecord(new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, seller4);
            SalesRecord saleRecord4 = new SalesRecord(new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, seller1);
            SalesRecord saleRecord5 = new SalesRecord(new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, seller3);
            SalesRecord saleRecord6 = new SalesRecord(new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, seller1);
            SalesRecord saleRecord7 = new SalesRecord(new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, seller2);
            SalesRecord saleRecord8 = new SalesRecord(new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, seller4);
            SalesRecord saleRecord9 = new SalesRecord(new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, seller6);
            SalesRecord saleRecord10 = new SalesRecord(new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, seller6);
            SalesRecord saleRecord11 = new SalesRecord(new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, seller2);
            SalesRecord saleRecord12 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, seller3);
            SalesRecord saleRecord13 = new SalesRecord(new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, seller4);
            SalesRecord saleRecord14 = new SalesRecord(new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, seller5);
            SalesRecord saleRecord15 = new SalesRecord(new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, seller1);
            SalesRecord saleRecord16 = new SalesRecord(new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, seller4);
            SalesRecord saleRecord17 = new SalesRecord(new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, seller1);
            SalesRecord saleRecord18 = new SalesRecord(new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, seller3);
            SalesRecord saleRecord19 = new SalesRecord(new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, seller5);
            SalesRecord saleRecord20 = new SalesRecord(new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, seller6);
            SalesRecord saleRecord21 = new SalesRecord(new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, seller2);
            SalesRecord saleRecord22 = new SalesRecord(new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, seller4);
            SalesRecord saleRecord23 = new SalesRecord(new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, seller2);
            SalesRecord saleRecord24 = new SalesRecord(new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, seller5);
            SalesRecord saleRecord25 = new SalesRecord(new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, seller3);
            SalesRecord saleRecord26 = new SalesRecord(new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, seller4);
            SalesRecord saleRecord27 = new SalesRecord(new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, seller1);
            SalesRecord saleRecord28 = new SalesRecord(new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, seller3);
            SalesRecord saleRecord29 = new SalesRecord(new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, seller5);
            SalesRecord saleRecord30 = new SalesRecord(new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, seller2);

            _context.Department.AddRange(
                department1,
                department2,
                department3,
                department4
            );

            _context.Seller.AddRange(
                seller1,
                seller2,
                seller3,
                seller4,
                seller5,
                seller6
            );

            _context.SalesRecord.AddRange(
                saleRecord1,
                saleRecord2,
                saleRecord3,
                saleRecord4,
                saleRecord5,
                saleRecord6,
                saleRecord7,
                saleRecord8,
                saleRecord9,
                saleRecord10,
                saleRecord11,
                saleRecord12,
                saleRecord13,
                saleRecord14,
                saleRecord15,
                saleRecord16,
                saleRecord17,
                saleRecord18,
                saleRecord19,
                saleRecord20,
                saleRecord21,
                saleRecord22,
                saleRecord23,
                saleRecord24,
                saleRecord25,
                saleRecord26,
                saleRecord27,
                saleRecord28,
                saleRecord29,
                saleRecord30
            );

            _context.SaveChanges();
        }
    }
}