using AXA.SharedServices.Contracts;
using AXA.SharedServices.SharedImplementations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXA.SharedServices.DataAccess
{
    public class CountryContext : DbContext 
    {

        public CountryContext(DbContextOptions<CountryContext> options) : base (options){ }      
        
        public DbSet<Country> Countries { get; set; }


    }
}
