using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Animation ani;
	// Use this for initialization
	void Start () {
		ani = this.GetComponent<Animation> ();
		ani.CrossFade ("idle");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
