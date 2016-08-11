using UnityEngine;
using System.Collections;

public class GameoverShari : MonoBehaviour {
	int go_sy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		go_sy +=1;
		transform.rotation=Quaternion.Euler(0,go_sy,0);

	}
}
