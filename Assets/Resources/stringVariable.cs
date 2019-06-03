using UnityEngine;

namespace Resources
{
	[CreateAssetMenu(menuName = "Variables/string")]
	public class stringVariable : ScriptableObject
	{

		[SerializeField] private string value;

		public string Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
