using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryASPNETCore.Model
{
    public class Character
    {
		public string Name;

		public static void Create(string characterName)
		{
			var character = new Character()
			{
				Name = characterName
			};
			GlobalVariables.Characters.Add(character);
		}

		public static List<Character> GetAll()
		{
			return GlobalVariables.Characters;
		}
    }
}
