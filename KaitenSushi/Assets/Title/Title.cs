using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {
    public GameObject Parts;
    public GameObject EscapeParts;
    public GameObject HighScore;
    public GameObject TitleParts;
    public GameObject StartParts;
    public GameObject HighScoreResetParts;


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            {
                EscapeParts.SetActive(true);
            //           Application.Quit();
            //           return;
            StartParts.SetActive(false);
            HighScoreResetParts.SetActive(false);
            TitleParts.SetActive(false);
        }
    }


    public void OnStart()
    {
        if(Parts.gameObject.activeSelf == false)
        {
            Application.LoadLevel("Main");
        }
        
    }

    public void OnHighScoreReset()
    {
        Parts.SetActive(true);
        TitleParts.SetActive(false);
        StartParts.SetActive(false);
        HighScoreResetParts.SetActive(false);
    }


    public void OnResetYes()
    {
        PlayerPrefs.DeleteKey("HighScore");
        HighScore.GetComponent<Text>().text = "HighScore:" + PlayerPrefs.GetInt("HighScore").ToString() + "円";
        Parts.SetActive(false);
        TitleParts.SetActive(true);
        StartParts.SetActive(true);
        HighScoreResetParts.SetActive(true);
    }
    public void OnResetNo()
    {
        Parts.SetActive(false);
        TitleParts.SetActive(true);
        StartParts.SetActive(true);
        HighScoreResetParts.SetActive(true);
    }


    public void OnEscapeYes()
    {
        Application.Quit();
        return;
    }
    public void OnEscapeNo()
    {
        EscapeParts.SetActive(false);
        StartParts.SetActive(true);
        HighScoreResetParts.SetActive(true);
        TitleParts.SetActive(true);
    }


}



