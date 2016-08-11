using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;
	public int ry_w2;
	public int sy_w2;
	float fprice;
	float frad;
	int price;
	string hyoka;

    public GameObject Score;
	
	// Use this for initialization
	void Start () {
		Shari.level += 1;
		frad = (float)Neta.abs_rad;
		fprice=10000 * (1 - frad/45);
		price=(int)fprice;
		Neta.Score += price;
		if (frad == 0) {
			hyoka = "PERFECT!!";
		}else{
			if (frad < 10) {
				hyoka = "Beautiful!!";
			}else{
				hyoka = "good!";
			}
		}
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip=audioClip;
		audioSource.Play ();





        Score.GetComponent<Text>().text =
            "Angle:" + Neta.abs_rad + "°\n" +
            hyoka + "\n" +
            "the price:" + price + "円\n" +
            "total price:" + Neta.Score + "円";
            
            //"HighScore:" + PlayerPrefs.GetInt("HighScore").ToString() + "円";

    }
	
	// Update is called once per frame
	void Update () {

	}
/*	void OnGUI(){
		GUIStyle labelStyle = new GUIStyle ();
		labelStyle.fontSize = 24;
		labelStyle.alignment = TextAnchor.MiddleCenter;
		GUIStyleState labelStyleState = new GUIStyleState ();
		labelStyleState.textColor = Color.red;
		labelStyle.normal = labelStyleState;
		GUI.Label (new Rect ((Screen.width - 400) / 2,
			(Screen.height - 200) / 2-20,
			400,
			60),
			"Angle:"+Neta.abs_rad+"°\n"+
			hyoka+"\n"+
			"the price:"+price+"円\n"+
			"total price:"+Neta.Score+"円",
			labelStyle);
//		if (GUI.Button (new Rect ((Screen.width - 200) / 2,
//			(Screen.height - 40) / 2+100,
//			200,
//			40),
//			"Next Order")) {
//		if(CrossPlatformInputManager.GetButtonDown("Next")){
//			Application.LoadLevel ("Main");
//		}
	}*/

    public void OnNext()
    {
        Application.LoadLevel("Main");
    }

}