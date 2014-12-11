using UnityEngine;
using System.Collections;

public class TitleCall : MonoBehaviour {

	public GUISkin skin;

	void OnGUI()
	{

		GUI.skin = skin;

		if ( GUI.Button( new Rect(120, 450, 400, 100), "Show Title Scene" ) )
		{
			Application.LoadLevel("Title");
		}

	}

}
