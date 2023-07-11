using PlantsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Application
{ 
	// different functions with plants
	public interface IPlantApplicable
	{
		Task<bool> AddPlantToDBAsync(IPlantable plantModel);
		
		bool EditPlantByName(IPlantable plantModel);
		
		Task<bool> DeletePlantByName(IPlantable plantModel);

	}
}
