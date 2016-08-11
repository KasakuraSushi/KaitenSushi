using UnityEngine;
using System.Collections;
//using UnitySampleAssets.CrossPlatformInput;
using UnityStandardAssets.CrossPlatformInput;

public class Neta : MonoBehaviour {
	public AudioClip shootClip;
	AudioSource shootSource;
	float ry;
	float sy;
	int ry_w;
    public static int ry_w2;
	public static int result_ry;
	int sy_w;
	public static int sy_w2;
	public static int result_sy;
	public static int rad;
	public static int abs_rad;
	public static int Score;
	public static bool shoot;
	// Use this for initialization
	void Start () {
		shoot = false;
		shootSource = gameObject.GetComponent<AudioSource> ();
		shootSource.clip=shootClip;
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyDown(KeyCode.Z)){
//		if (Input.GetMouseButtonDown (0)){
/*		if(CrossPlatformInputManager.GetButtonDown("Shoot")){
			if (shoot == false) {
				shootSource.Play ();
				shoot = true;
			}
		}*/
		var axis = CrossPlatformInputManager.GetAxis ("Horizontal");
		if (axis > 0){
			ry = transform.localEulerAngles.y;
			ry += 1;
			transform.rotation=Quaternion.Euler(0,ry,0);
		}

		if (axis < 0){
			ry = transform.localEulerAngles.y;
			ry -= 1;
			transform.rotation=Quaternion.Euler(0,ry,0);
		}


//		if (Input.GetKey (KeyCode.LeftArrow)) {
//			ry = transform.localEulerAngles.y;
//			ry -= 1;
//			transform.rotation=Quaternion.Euler(0,ry,0);
//		}
//		if (Input.GetKey (KeyCode.RightArrow)) {
//			ry = transform.localEulerAngles.y;
//			ry += 1;
//			transform.rotation=Quaternion.Euler(0,ry,0);
//		}

		if(shoot){
			Vector3 v = this.transform.position;
			v.y -= 0.03f;
			transform.position=v;
		}
		

		ry_w=(int)ry;
		ry_w2 = ry_w % 180;
		sy_w=(int)Shari.sy;
		sy_w2 = sy_w % 180;


	}

	void OnCollisionEnter(){
		result_ry = ry_w2;
		result_sy = sy_w2;
		rad = result_ry - result_sy;
		abs_rad = System.Math.Abs (rad);
		if (abs_rad > 90) {
			abs_rad = 180 - abs_rad;
		}
		if (abs_rad < 45) {
			Application.LoadLevel ("Result");
		} else {
			Application.LoadLevel ("GameOver");
		}

	}

/*	void OnGUI(){
		//public static int GetFontSizeFromWidth(GUIStyle style, GUIContent contents, float width) {
		//	int size = 0;
		//	for (int i = 1; ; i++) {
		//		style.fontSize = i;
		//		Vector2 v = style.CalcSize(contents);//mojinonagasa
		//		if (v.x < width) { size = i; } else { break; } } return size; } ;
		GUIStyle labelStyle = new GUIStyle();
		labelStyle.fontSize=24;
		labelStyle.alignment=TextAnchor.UpperLeft;
		GUIStyleState labelStyleState = new GUIStyleState();
		labelStyleState.textColor = Color.white;
		labelStyle.normal=labelStyleState;
//		Vector2 v = labelStyle.CalcSize ("Neta Angle:ryw2°");
		GUI.Label(new Rect (0,
			0,
			200,40),
			"Neta Angle:"+ry_w2+"°\n"+
			"Shari Angle:"+sy_w2+"°\n",
			labelStyle);
	}*/
}


