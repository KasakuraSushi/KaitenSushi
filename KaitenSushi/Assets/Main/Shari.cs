using UnityEngine;
using System.Collections;

public class Shari : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;

	public static short sy = 0;
	public static short level = 1;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip=audioClip;
		audioSource.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		sy +=level;
		transform.rotation=Quaternion.Euler(0,sy,0);

	
	}


}