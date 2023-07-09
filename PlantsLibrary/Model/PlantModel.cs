using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsLibrary.Model
{
	public class PlantModel : IPlantable
	{
		public long Id { get; set; }
		public string Name { get; set; } = "";
		public string Link { get; set; } = "";
		public string Description { get; set; } = "";
		public string Handling { get; set; } = "";
		public byte[] ImageBytes { get; set; } = Array.Empty<byte>();
	}
}
