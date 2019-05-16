using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInput
{
	public static Vector2 Move
	{
		get
		{
			var val = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
			return val;
		}
	}
}

// Camera.main.screentoworldpoint