using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryASPNETCore
{
    public static class GlobalVariables
    {
		public static List<Model.Character> Characters { get; set; } = new List<Model.Character>();
    }
}
