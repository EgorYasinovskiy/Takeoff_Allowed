using System;
using System.Collections.Generic;
using System.Text;

namespace TakeoffAllowed.Model.Sctructs
{
	/// <summary>
	///	Describes a point in three-dimensional space by specifying three spatial coordinates
	/// </summary>
	public struct PointF3D
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		public PointF3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}
	}
}
