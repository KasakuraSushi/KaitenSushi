using UnityEngine;
using System.Collections;

public class ResultShari : MonoBehaviour {
	int result_sy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		result_sy +=1;
		transform.rotation=Quaternion.Euler(0,result_sy,0);
	}
}
