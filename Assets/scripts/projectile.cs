using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {
	public float  projectileSpeed;
	 private Transform myTrans;
	// Use this for initialization
	void Start () {
		myTrans = transform;
	}
	
	// Update is called once per frame
	void Update () {
	float outToMove = projectileSpeed * Time.deltaTime;
		myTrans.Translate(Vector3.up * outToMove);
		if (myTrans.position.y > 6.25f)
		{
			Destroy(gameObject);
		}
	}
}
