using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ReStart : MonoBehaviour {

	void Start () 
	{ 
		GameObject btnObj = GameObject.Find("Restart");
		Button btn = btnObj.GetComponent<Button>(); 
		btn.onClick.AddListener(delegate () 
			{ 
				this.GoNextScene(btnObj); 
			}); 
	}

	public void GoNextScene(GameObject NScene) { 
		Application.LoadLevel("Main");
	}
}
