using UnityEngine;

namespace Resources.Items
{
    [CreateAssetMenu]
    public class ItemScriptable : ScriptableObject
    {
        public string Name;
        public int Value;
        public Sprite Display;
    }
}
