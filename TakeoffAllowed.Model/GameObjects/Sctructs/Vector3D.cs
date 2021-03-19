using System;
using System.Collections.Generic;
using System.Text;

namespace TakeoffAllowed.Model.Sctructs
{
	public struct Vector3D
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public Vector3D(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		public Vector3D(Point3D point)
		{
			X = point.X;
			Y = point.Y;
			Z = point.Z;
		}
	}
}
