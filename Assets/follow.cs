using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
    public GameObject target;
    private Transform t;
	// Use this for initialization
	void Start () {
        t = target.GetComponent<Transform>();
	}

    // Update is called once per frame
    private void LateUpdate()
    {
        Debug.Log(t.position+"+"+this.transform.position);
        transform.position = new Vector3(t.position.x, t.position.y, -10);
    }
}
