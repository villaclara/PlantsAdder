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

		public PlantWorker() : this(new ApplicationContext())
		{ }

		private PlantWorker(ApplicationContext context)
		{
			_context = context;
		}

		public async Task<bool> AddPlantToDBAsync(IPlantable plantModel)
		{
			_context.Plants.Add((PlantModel)plantModel);
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<bool> DeletePlantByName(IPlantable plantName)
		{
			_context.Plants.Remove((PlantModel)plantName);
			await _context.SaveChangesAsync();
			return true;
		}

		public bool EditPlantByName(IPlantable plantModel)
		{
			
			var pl = _context.Plants.FirstOrDefault(p => p.Id == plantModel.Id)!;
			pl.Name = plantModel.Name;
			pl.Description = plantModel.Description;
			pl.Link = plantModel.Link;
			pl.Handling = plantModel.Handling;



			_context.SaveChanges();

			return true;
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
