using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDN_Toolbox.GlobalVariables.MousePosition
{
	static public class LastMousePosition
	{
		private static int mousePosX = 0;
		private static int mousePosY = 0;

		public static int MousePosX { get => mousePosX; set => mousePosX = value; }
		public static int MousePosY { get => mousePosY; set => mousePosY = value; }
	}
}
