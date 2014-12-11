using UnityEngine;
using System.Collections;

public class MainCall : MonoBehaviour {

	public GUISkin skin;

	void OnGUI()
	{

		GUI.skin = skin;

		if ( GUI.Button( new Rect(120, 450, 400, 100), "Show Main Scene" ) )
		{
			Application.LoadLevel("Main");
		}

	}

}
