using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCanvas : MonoBehaviour {
    public GameObject RadText;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        RadText.GetComponent<Text>().text = "Neta Angle:" + Neta.ry_w2 + "°\n" +
            "Shari Angle:" + Neta.sy_w2 + "°\n";
	}

    public void OnShoot()
    {
        Neta.shoot = true;
    }


}
