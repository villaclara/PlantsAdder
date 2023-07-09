using PlantsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Application
{
	public interface IGetPlant
	{
		List<PlantModel> GetAllPlants();

		PlantModel? GetPlantByName(string name);

		PlantModel? GetPlantById(int id);

	}
}
