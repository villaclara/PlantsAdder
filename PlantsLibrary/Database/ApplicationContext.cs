using Microsoft.EntityFrameworkCore;
using PlantsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Database
{
	public class ApplicationContext : DbContext
	{
		public DbSet<PlantModel> Plants { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=plants.db");
		}

		public ApplicationContext()
		{
			Database.EnsureCreated();
		}

	}
}
