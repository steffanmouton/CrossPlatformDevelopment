using UnityEngine;

namespace Resources
{
	[CreateAssetMenu(menuName = "Variables/float")]
	public class floatVariable : ScriptableObject
	{

		[SerializeField] private float value;
		// Use this for initialization
		public float Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
