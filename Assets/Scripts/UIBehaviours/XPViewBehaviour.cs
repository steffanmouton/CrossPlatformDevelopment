using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;
using UnityEngine.UI;

public class XPViewBehaviour : MonoBehaviour
{
	public Text xpView;
	public Text levelView;
	public PlayerDataVariable pdRef;

	private void Update()
	{
		xpView.text = "XP: " + pdRef.xpRef.Value;
		levelView.text = "Level: " + pdRef.levelRef.Value;
	}
}
