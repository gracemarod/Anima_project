//Creator: Grace M. Rodriguez 
//This scripts goes in all the buttons to for scene change.

using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

//	Accepts a string, which is going to be the name of the scene where, after the button is pressed, it will take you there.
	public void changeScene(string sceneToChangeTo){
		Application.LoadLevel(sceneToChangeTo);
	}

}

