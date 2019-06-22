using UnityEngine;

namespace Resources
{
	/// <summary>
	/// Custom Variable type. Used to store information regarding a player character, such as
	/// Name, XP, and Level.
	/// </summary>
	[CreateAssetMenu(menuName = "Player/data")]
	public class PlayerDataVariable : ScriptableObject
	{
		
		public intVariable xpRef;
		public intVariable levelRef;
		[SerializeField] private int _experience;
		[SerializeField] private int _level;
		public int Experience
		{
			get { return _experience; }
			set
			{
				_experience = value;
				xpRef.Value = value;
				
				Level = 1 + value / 7;
			}
		}

		public int Level
		{
			get { return _level; }
			set
			{
				_level = value;
				levelRef.Value = value;
			}
		}
		
		// Updates the local variables to match the reference ScriptableObjects
		public void UpdateValues()
		{
			Experience = xpRef.Value;
			Level = levelRef.Value;
		}
	}
}
