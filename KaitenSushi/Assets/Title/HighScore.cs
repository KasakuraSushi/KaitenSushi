using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public string hsText;
	// Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = "HighScore:"+PlayerPrefs.GetInt("HighScore").ToString()+"円";
        //hsText.text = PlayerPrefs.GetInt("HighScore");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
