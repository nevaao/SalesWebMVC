﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}!")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} required!")]
        [EmailAddress(ErrorMessage = "Enter a valid email!")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} required!")]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}!")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sale)
        {
            Sales.Add(sale);
        }

        public void RemoveSales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }

        public double TotalSales(DateTime initialDate, DateTime finalDate)
        {
            return Sales.Where(s => s.Date >= initialDate && s.Date <= finalDate).Sum(s => s.Amount);
        }
    }
}
