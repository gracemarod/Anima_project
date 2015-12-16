using UnityEngine;
using System.Collections;

public class levelNameBehavior : MonoBehaviour {

	public GameObject levelController;
	levelBehavior lController;

	// Use this for initialization
	void Start () 
	{
		lController = levelController.GetComponent<levelBehavior>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (lController.currentLevel == 1)
			this.GetComponent<GUIText>().text = "avenida universidad";
		if (lController.currentLevel == 2)
			this.GetComponent<GUIText>().text = "       paseo de diego";
		if (lController.currentLevel == 3)
			this.GetComponent<GUIText>().text = "plaza de convalecencia";
	}
}
