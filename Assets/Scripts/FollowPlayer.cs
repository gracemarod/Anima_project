using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	//Variable for sound
	private AudioSource audioSource ;

	public GameObject player;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource >();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newPos = new Vector3(player.transform.position.x, transform.position.y,transform.position.z);
		transform.position = newPos;
//		audioSource.Play();
	}
}
