using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class login : MonoBehaviour 
{
	//Toggle
	public Toggle remPasswd;
	private Toggle fogPasswd;
	
	//注册信息
	public InputField inputName;
	public InputField inputPaswd;

	void Start () 
	{ 
		GameObject btnObj = GameObject.Find("btn_login");
		//"Button"为你的Button的名称 
		Button btn = btnObj.GetComponent<Button>(); 

		btn.onClick.AddListener(delegate () 
			{ 
				if(inputName.text.Trim() == "root"&&inputPaswd.text.Trim() == "root")
				{
					this.GoNextScene(btnObj); 
				}
				else
				{
					Debug.Log ("登录失败!");
				}
			}); 
	}

	public void GoNextScene(GameObject NScene) { 
		Application.LoadLevel("Main");
	} 

	// Update is called once per frame
	void Update () 
	{
		//如果选中记住密码
		if(remPasswd.isOn)
		{
			//填充数据，在这里仅仅是模拟，如果大家想做的真实，可以写个配置文件
			inputPaswd.text = "root";
		}
		else
		{
			inputPaswd.text = inputPaswd.text;
		}
	}

	void regist()
	{
		//如果可以的或直接将数据写入数据库在这里我们仅仅模拟下功能就行了
		if(inputName.text!=""&&inputPaswd.text!="")
		{
			Debug.Log("注册成功");
		}
		else
		{
			Debug.Log ("请输入注册信息");
		}
	}
}
