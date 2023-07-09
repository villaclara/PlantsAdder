using PlantsLibrary.Database;
using PlantsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Application
{
	public class PlantWorker : IPlantApplicable, IGetPlant
	{
		private readonly ApplicationContext _context;

		public PlantWorker(ApplicationContext context)
		{
			_context = context;
		}

		public async Task<bool> AddPlantToDBAsync(PlantModel plantModel)
		{
			_context.Plants.Add(plantModel);
			await _context.SaveChangesAsync();
			return true;
		}

		public bool DeletePlantByName(string plantName)
		{
			throw new NotImplementedException();
		}

		public bool EditPlantByName(string plantName)
		{
			throw new NotImplementedException();
		}

		public List<PlantModel> GetAllPlants()
		{
			return _context.Plants.ToList() ?? new List<PlantModel>();
		}

		public PlantModel? GetPlantById(int id)
		{
			throw new NotImplementedException();
		}

		public PlantModel? GetPlantByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
