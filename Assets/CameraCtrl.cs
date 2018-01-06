using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour
{
	public bool startMove;
	public Transform target;
	public float speed;
	public Vector3 offset;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(startMove)
		{
			this.transform.position = Vector3.MoveTowards(this.transform.position,target.position + offset,Time.deltaTime * speed);

			if(this.transform.position == target.position + offset)
			{
				startMove = false;
			}
		}
	}
}
