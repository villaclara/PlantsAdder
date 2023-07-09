using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Model
{
	public interface IPlantable : IPlantHandlingable
	{
		string Name { get; set; }
		string Link { get; set; }
		string Description { get; set; }

		byte[] ImageBytes { get; set; }

	}
}
