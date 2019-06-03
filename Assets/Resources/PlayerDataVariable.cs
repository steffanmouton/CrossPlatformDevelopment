using UnityEngine;

namespace Resources
{
	[CreateAssetMenu(menuName = "Player/data")]
	public class PlayerDataVariable : ScriptableObject
	{
		
		public intVariable xpRef;
		public intVariable levelRef;
		public stringVariable saveName;
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
	}
}
