using UnityEngine;

namespace Resources
{
	[CreateAssetMenu(menuName = "Global/SaveLoad")]
	public class Global : ScriptableObject
	{

		public void Save(Object obj)
		{
			var data = JsonUtility.ToJson(obj, true);
			var path = Application.persistentDataPath + "/PlayerData.json";
			System.IO.File.WriteAllText(path, data);
			Debug.Log(path);
		}
	
		public T Load<T>(Object obj) where T : ScriptableObject
		{
			var path = Application.persistentDataPath + "/PlayerData.json";
			var data = System.IO.File.ReadAllText(path);
			JsonUtility.FromJsonOverwrite(data, obj);
			return obj as T;
		}
	}
}
