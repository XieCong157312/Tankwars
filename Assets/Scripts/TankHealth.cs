using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

	public int hp = 100;
	public GameObject tankExplosion;
	public AudioClip tankExplosionAudio;
	public Slider hpSlier;
	public Text winText;

	private int hpTotal;
	private GameObject btnObj;

	// Use this for initialization
	void Start () {
		hpTotal = hp;
		winText.text = "";
		//btnObj = GameObject.Find("ReStart");
		//btnObj.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void TakeDamage(){
		if (hp <= 0) //如果开始就hp小于0，坦克不用受到伤害
			return;
		hp -= Random.Range (10, 20); //10~20随机伤害
		hpSlier.value = (float)hp/hpTotal;
		if (hp <= 0){
			AudioSource.PlayClipAtPoint (tankExplosionAudio, transform.position);
			GameObject.Instantiate (tankExplosion, transform.position+Vector3.up, transform.rotation);//坦克爆炸特效向上移动1米
			GameObject.Destroy(this.gameObject);
			winText.text = this.name+" Win";
			Application.LoadLevel("UPauseMenu");
			//btnObj.SetActive (true);
		}
	}


}
