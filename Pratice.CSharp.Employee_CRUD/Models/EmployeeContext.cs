using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Pratice.CSharp.Employee_CRUD.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

   
    }
}
