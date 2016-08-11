using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;


public class GameOver : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;
	public int ry_w2;
	public int sy_w2;
	int price;
    private int highScore;
    public bool newRecord=false;
    public char HighScoreBord;

    public GameObject Result;
    public GameObject NewRecord;


    // Use this for initialization
    void Start ()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }

        if (Neta.Score > highScore)
        {
            newRecord = true;
        }
        //HighScore.text = "HighScore:" + PlayerPrefs.GetInt("HighScore") + "円";
        //HighScoreBord.text = "HighScore:" +  "円";

        Result.GetComponent<Text>().text =
            "Angle:" + Neta.abs_rad + "°\n" +
            "Bad......" + "\n" +
            "the price:" + price + "円\n" +
            "total price:" + Neta.Score + "円";

        if (newRecord == true)
        {
            NewRecord.GetComponent<Text>().text = "NeW Record!!";
        }
    }
		



/*    void OnGUI(){
        if(newRecord == false)
        {
            GUIStyle labelStyle = new GUIStyle();
            labelStyle.fontSize = 24;
            labelStyle.alignment = TextAnchor.MiddleCenter;
            GUIStyleState labelStyleState = new GUIStyleState();
            labelStyleState.textColor = Color.black;
            labelStyle.normal = labelStyleState;
            GUI.Label(new Rect((Screen.width - 400) / 2,
                (Screen.height - 200) / 2 - 20,
                400,
                60),
                "Angle:" + Neta.abs_rad + "°\n" +
                "Bad......\n" +
                "the price:" + "0円\n" +
                "total price:" + Neta.Score + "円",
                labelStyle);
        }
        else
        {
            GUIStyle labelStyle = new GUIStyle();
            labelStyle.fontSize = 24;
            labelStyle.alignment = TextAnchor.MiddleCenter;
            GUIStyleState labelStyleState = new GUIStyleState();
            labelStyleState.textColor = Color.black;
            labelStyle.normal = labelStyleState;
            GUI.Label(new Rect((Screen.width - 400) / 2,
                (Screen.height - 200) / 2 ,
                400,
                60),
                "Angle:" + Neta.abs_rad + "°\n" +
                "Bad......\n" +
                "the price:" + "0円\n" +
                "total price:" + Neta.Score + "円\n"+
                "NewRecord!!!!",
                labelStyle);
        }
		
//		if (GUI.Button (new Rect ((Screen.width - 200) / 2,
//			(Screen.height-40) / 2+100,
//			200,
//			40),
//			"Go to Title")) {
		if(CrossPlatformInputManager.GetButtonDown("Title")){
            if (newRecord == true)
            {
                PlayerPrefs.SetInt("HighScore", Neta.Score);
            }
                Application.LoadLevel ("Title");
		}
	}*/

    public void OnTitle()
    {
        Application.LoadLevel("Title");
    }



    public void OnTwitter()
    {
        if (newRecord == true)
        {
            PlayerPrefs.SetInt("HighScore", Neta.Score);
        }

        //Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL("私は"+ +Neta.Score + "円分のスシを作りました。\n#KaitenSushi"));
        Application.LoadLevel("TwitterAPI");

    }

}