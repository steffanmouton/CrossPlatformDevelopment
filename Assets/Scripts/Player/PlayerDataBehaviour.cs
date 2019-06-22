using Resources;
using UnityEngine;

namespace Player
{
	public class PlayerDataBehaviour : MonoBehaviour
	{
		[SerializeField]
		private PlayerDataVariable _runtimeInstance;
		[SerializeField] private Global saveBot;

		// Use this for initialization
		void Start ()
		{
			_runtimeInstance = Instantiate(_runtimeInstance);
		}

		public void Save()
		{
			saveBot.Save(_runtimeInstance);
		}

		public void Load()
		{
			_runtimeInstance = saveBot.Load<PlayerDataVariable>(_runtimeInstance);
			_runtimeInstance.xpRef.Value = _runtimeInstance.Experience;
			_runtimeInstance.levelRef.Value = _runtimeInstance.Level;
		}

		public void GainExperience()
		{ 
			_runtimeInstance.Experience += 1;
		}
		
		public void Reset()
		{
			_runtimeInstance.xpRef.Value = 0;
			_runtimeInstance.levelRef.Value = 0;
			_runtimeInstance.UpdateValues();
		}
	}
}
