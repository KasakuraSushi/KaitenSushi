using UnityEngine;
using System.Collections;

public class GameoverNeta : MonoBehaviour {
	int go_ry;
	// Use this for initialization
	void Start () {
		go_ry = Neta.rad;
	}
	
	// Update is called once per frame
	void Update () {
		go_ry +=1;
		transform.rotation=Quaternion.Euler(0,go_ry,0);
	}
}
