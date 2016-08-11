using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TwitterComponentHandler : MonoBehaviour {

    public GameObject inputPINField;
    public GameObject inputTweetField;
    public GameObject Template;
    public GameObject explain;
    public GameObject TweetField;

    private const string CONSUMER_KEY = "5UjnhyDj2lZKIUGWnKAMky1G3";
    private const string CONSUMER_SECRET = "0LNJjJovTt1BMaKfSjIEiT4ug1TbYoNo1wWQ9GweT0wWroZS0M";

    Twitter.RequestTokenResponse m_RequestTokenResponse;
    Twitter.AccessTokenResponse m_AccessTokenResponse;

    const string PLAYER_PREFS_TWITTER_USER_ID = "TwitterUserID";
    const string PLAYER_PREFS_TWITTER_USER_SCREEN_NAME = "TwitterUserScreenName";
    const string PLAYER_PREFS_TWITTER_USER_TOKEN = "TwitterUserToken";
    const string PLAYER_PREFS_TWITTER_USER_TOKEN_SECRET = "TwitterUserTokenSecret";

    const string PLAYER_PREFS_TWITTER_TWEETED_IDS = "TwitterTweetedIDs";


    // Use this for initialization
    void Start () {
        Template.GetComponent<Text>().text = "私は" + Neta.Score + "円分のスシを作りました。 #KaitenSushi ";
        //Template.GetComponent.< Text > ().text = "私は" + Neta.Score + "円分のスシを作りました。 #KaitenSushi "
        //HighScore.GetComponent<Text>().text= "HighScore:" + PlayerPrefs.GetInt("HighScore").ToString() + "円";
        explain.GetComponent<Text>().text = "上記テンプレートと下記コメントを投稿します。";
    }

    // Update is called once per frame
    void Update () {
	
	}


    public void OnClickGetPINButon()
    {
        StartCoroutine(Twitter.API.GetRequestToken(CONSUMER_KEY, CONSUMER_SECRET,
            new Twitter.RequestTokenCallback(this.OnRequestTokenCallback)));
    }

    public void OnClickAuthPINButon()
    {
        string myPIN = inputPINField.GetComponent<InputField>().text;

        StartCoroutine(Twitter.API.GetAccessToken(CONSUMER_KEY, CONSUMER_SECRET, m_RequestTokenResponse.Token, myPIN,
            new Twitter.AccessTokenCallback(this.OnAccessTokenCallback)));
    }

    public void OnClickTweetButon()
    {
        string myTweet = "私は" + Neta.Score + "円分のスシを作りました。 #KaitenSushi " + inputTweetField.GetComponent<InputField>().text;

        StartCoroutine(Twitter.API.PostTweet(myTweet, CONSUMER_KEY, CONSUMER_SECRET, m_AccessTokenResponse,
            new Twitter.PostTweetCallback(this.OnPostTweet)));

    }





public void OnClickTitle()
    {
        Application.LoadLevel("Title");
    }


    /* Callback Event */


    void OnRequestTokenCallback(bool success, Twitter.RequestTokenResponse response)
    {
        if (success)
        {
            string log = "OnRequestTokenCallback - succeeded";
            log += "\n    Token : " + response.Token;
            log += "\n    TokenSecret : " + response.TokenSecret;
            print(log);

            m_RequestTokenResponse = response;

            print(response.Token);
            print(response.TokenSecret);

            Twitter.API.OpenAuthorizationPage(response.Token);
        }
        else
        {
            print("OnRequestTokenCallback - failed.");
        }
    }

    void OnAccessTokenCallback(bool success, Twitter.AccessTokenResponse response)
    {
        if (success)
        {
            string log = "OnAccessTokenCallback - succeeded";
            log += "\n    UserId : " + response.UserId;
            log += "\n    ScreenName : " + response.ScreenName;
            log += "\n    Token : " + response.Token;
            log += "\n    TokenSecret : " + response.TokenSecret;
            print(log);

            m_AccessTokenResponse = response;

            PlayerPrefs.SetString(PLAYER_PREFS_TWITTER_USER_ID, response.UserId);
            PlayerPrefs.SetString(PLAYER_PREFS_TWITTER_USER_SCREEN_NAME, response.ScreenName);
            PlayerPrefs.SetString(PLAYER_PREFS_TWITTER_USER_TOKEN, response.Token);
            PlayerPrefs.SetString(PLAYER_PREFS_TWITTER_USER_TOKEN_SECRET, response.TokenSecret);

        }
        else
        {
            print("OnAccessTokenCallback - failed.");
        }
    }

    void OnPostTweet(bool success)
    {
        print("OnPostTweet - " + (success ? "succedded." : "failed."));

    }








}
