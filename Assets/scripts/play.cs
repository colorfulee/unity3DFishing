using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	public float playSpeed;
	public GameObject ProjectilePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	float outToMove  = Input.GetAxis("Horizontal") * playSpeed * Time.deltaTime;
		transform.Translate(Vector3.right * outToMove);
		
		if(Input.GetKeyDown("space"))
		{
			Vector3 position = new Vector3(transform.position.x,transform.position.y +(transform.localScale.y/1));
			
			Instantiate(ProjectilePrefab,position,Quaternion.identity);
		}
		
		if (transform.position.x <= -8.25f)
		transform.position = new Vector3(8.25f, transform.position.y,
		transform.position.z);
		else if (transform.position.x >= 8.25f)
		transform.position = new Vector3(-8.25f, transform.position.y,
		transform.position.z);
	}
}
