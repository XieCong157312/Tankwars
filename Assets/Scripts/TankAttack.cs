using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

	public GameObject shellPrefab;
	public Transform firePosition;
	public KeyCode fireKey = KeyCode.Space; //发射键,默认空格
	public float shellSpeed = 15; //子弹发射速度

	// Use this for initialization
	void Start () {
		firePosition = transform.Find ("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (fireKey)) {
			GameObject go = GameObject.Instantiate (shellPrefab,firePosition.position,firePosition.rotation);
			go.GetComponent<Rigidbody> ().velocity = go.transform.forward * shellSpeed;
		}
	}
}
