using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

	public Transform player1;
	public Transform player2;

	private Vector3 offset;
	private Camera camera;

	// Use this for initialization
	void Start () {
		offset = transform.position - (player1.position + player2.position) / 2;
		camera = this.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player1 == null || player2 == null)
			return;
		camera.transform.position = (player1.position + player2.position) / 2 + offset; //距离
		//使得Camera的size和distance的比例
		float distance = Vector3.Distance (player1.position, player2.position);
		float size = distance * 1;
		if (size <= 28) {
			camera.orthographicSize = size;
		}
	}
}
