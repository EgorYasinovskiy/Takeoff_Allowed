using System;
using TakeoffAllowed.Model.Sctructs;

namespace TakeoffAllowed.Model.GameObjects
{
	internal class PawnAirplane : Airplane
	{
		public PawnAirplane(double velocity, PointF3D location, Vector3D direction) : base(velocity, location, direction)
		{
		}

		#region Airplane movement logic

		// Lower height for landing or to avoid collision.
		public void Decline()
		{
			throw new NotImplementedException("Impliment declining method.");
		}

		// Raise height for takeoff, second landing circle or to avoid collisions .
		public void RaiseUp()
		{
			throw new NotImplementedException("Impliment climbing method.");
		}

		// Turn aside to avoid collisions.
		public void TurnAside()
		{
			throw new NotImplementedException("Impliment pivot method.");
		}

		// Aircraft turn and go-around.
		public void GoAround()
		{
			throw new NotImplementedException("Impliment reversal method.");
		}

		#endregion Airplane movement logic

		// Для разных уровней и сложностей должны будут появляться разные факторы, вляющие на логику действий передвижения.
		// Например, на легком уровне мы можем отправлять на посадку, столько раз, сколько это потребуется, на уровнях сложнее мы должны будем учитывать количество топлива
		// TODO: Добавить систему топлива в модель. Реализовать ее влияние на повышенном уровне сложности.
		// И уменьшать его с каждым заходом на второй круг.
	}
}