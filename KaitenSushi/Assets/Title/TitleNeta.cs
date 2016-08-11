using UnityEngine;
using System.Collections;

public class TitleNeta : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;
    float r = 0;
    //public string Highscore;
    //public string Takaiten;
    //public GameObject HighScore;
    // Use this for initialization
    void Start()
    {

        Shari.level = 1;
        Neta.Score = 0;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

        //Takaiten = PlayerPrefs.GetInt("HighScore").ToString();
        //Highscore.text = "HighScore:";// +Takaiten+"円";
        //Highscore.text = 1;// +Takaiten+"円";
        //HighScore.text = PlayerPrefs.GetInt("HighScore");//.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        r += 1f;
        transform.rotation = Quaternion.Euler(0, r, 0);
        //		if (Input.GetMouseButtonUp (0)) {
        //			audioSource.Play ();
        //			Application.LoadLevel ("Main");
        //		}


        //		if (Application.platform == RuntimePlatform.Android) {

        //		}
    }

//    void OnGUI()
//    {
//       GUIStyle labelStyle = new GUIStyle();
/*        labelStyle.fontSize = 32;
        labelStyle.alignment = TextAnchor.MiddleCenter;
        GUIStyleState labelStyleState = new GUIStyleState();
        labelStyleState.textColor = Color.red;
        labelStyle.normal = labelStyleState;
        GUI.Label(new Rect((Screen.width - 400) / 2,
            (Screen.height - 200) / 2,
            400,
            60),
            "Kaiten Sushi",
            labelStyle);


        		if (GUI.Button (new Rect ((Screen.width - 200) / 2,
			(Screen.height + 120) / 2,
			200,
			40),
			"TAP TO START")) {
			//Application.LoadLevel ("Main");
		}

    }*/

}



