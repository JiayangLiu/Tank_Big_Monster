using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameOnEscape : MonoBehaviour 
{
	public Transform pauseCanvas;

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			PauseAndResume ();
		}
	}

	public void PauseAndResume()
	{
		if (pauseCanvas.gameObject.activeInHierarchy == false) 
		{
			pauseCanvas.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
		else //Already in PausePanel, use ESC to exit 
		{
			pauseCanvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}

}
