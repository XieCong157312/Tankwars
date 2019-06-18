using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 10; //1s 30度
	public float number = 1; //增加一个编号，通过编号区分不同的控制
	public AudioClip idleAudio;
	public AudioClip drivingAudio;

	private Rigidbody rigidbody;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
		audio = this.GetComponent<AudioSource> ();
		//rigidbody.transform.position = new Vector3(Random.Range(-50,50),0,Random.Range(-50,50));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//前进后退
		float v = Input.GetAxis ("VerticalPlayer"+number);
		rigidbody.velocity = transform.forward * speed * v;

		//旋转
		float h = Input.GetAxis ("HorizontalPlayer"+number);
		rigidbody.angularVelocity = transform.up * angularSpeed * h; //transform.up按照y旋转

		if (Mathf.Abs (h) > 0.1 || Mathf.Abs (v) > 0.1) { //绝对值>0.1
			audio.clip = drivingAudio;
			if(audio.isPlaying == false)
			audio.Play ();
		} else {
			audio.clip = idleAudio;
			if(audio.isPlaying == false)
			audio.Play ();
		}
	}
}
