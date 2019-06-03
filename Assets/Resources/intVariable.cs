using UnityEngine;

namespace Resources
{
	[CreateAssetMenu(menuName = "Variables/int")]
	public class intVariable : ScriptableObject
	{

		[SerializeField] private int value;

		public int Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
