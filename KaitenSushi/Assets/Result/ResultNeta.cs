using UnityEngine;
using System.Collections;

public class ResultNeta : MonoBehaviour {
	int result_ry;
	// Use this for initialization
	void Start () {
		result_ry = Neta.rad;
	
	}
	
	// Update is called once per frame
	void Update () {
		result_ry +=1;
		transform.rotation=Quaternion.Euler(0,result_ry,0);	
	}
}
