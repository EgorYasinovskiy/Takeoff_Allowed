using System;

namespace TakeoffAllowed.Model.GameObjects.ShopItems
{
	public class Base
	{
		public uint Price { get; private set; }
		public string Name { get; private set; }
		public string IconPath { get; set; }
		public byte Tier { get; set; }
		// Maybe some more fields in future
		public bool CanBuy(Store store)
		{
			//The method will have to take into account previous purchases and the amount of the player's money. Solution options:
			//1 - Come up with a model that stores this data and pass it to the method.
			//2 - Add a delegate to the class, implementing which for each specific model we will issue the corresponding value.
			throw new NotImplementedException();
		}
		public void Buy()
		{
		}
	}
}
