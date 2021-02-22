//------------------------------------------------------------------------------
// Copyright: (c) 2006/2007 Edlin Software, Russia
//------------------------------------------------------------------------------
// $Source$
// Unit:        Controls\Src\Controls\WinForms
// Author:      Ivan_Yakimov
// Responsible: Ivan_Yakimov
//------------------------------------------------------------------------------
// Description: Class of utilities for WinForms programming.
//------------------------------------------------------------------------------
// $Log$
//------------------------------------------------------------------------------
using System.Windows.Forms;
using System.Drawing;

namespace EdlinSoftware.Controls.WinForms
{
    /// <summary>
    /// Class of utilities for WinForms programming.
    /// </summary>
    public class Utils
	{
		/// <summary>
		/// Finds child control at given point.
		/// </summary>
		/// <param name="parent">Parent control.</param>
		/// <param name="p">Point in screen coordinates.</param>
		/// <returns>Child control at given point.</returns>
		public static Control FindChildAtScreenPoint(Control parent, Point p)
		{
			if (parent == null)
				return null;

			p = parent.PointToClient(p);

			return FindChildAtControlPoint(parent, p);
		}

		/// <summary>
		/// Finds child control at given point.
		/// </summary>
		/// <param name="parent">Parent control.</param>
		/// <param name="p">Point in control coordinates.</param>
		/// <returns>Child control at given point.</returns>
		public static Control FindChildAtControlPoint(Control parent, Point p)
		{
			if (parent == null)
				return null;

			Control child = parent.GetChildAtPoint(p);
			if (child == null)
				return parent;

			Point childPoint = new Point(p.X - child.Location.X, p.Y - child.Location.Y);

			return FindChildAtControlPoint(child, childPoint);
		}
	}
}
