using System.Collections.Generic;
using TakeoffAllowed.Model.GameObjects.Enums;
using TakeoffAllowed.Model.GameObjects;
using TakeoffAllowed.Model.GameObjects.ShopItems;

namespace TakeoffAllowed.Model
{
	public class Level
	{

		//Model on the level
		public List<Airplane> NPCPlanes { get; set; }
		public uint Credits { get; set; }
		public Store Store { get; set; }

		// Level parametrs
		public Difficulty Difficulty { get;set }
		public bool ExtraTasks { get; set; }
		public bool IsPaused { get; set; }
	}
}
