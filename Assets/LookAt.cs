using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
    public GameObject OrbitObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (OrbitObject == null)
        //    return;
        transform.LookAt(OrbitObject.transform);
        transform.Rotate(0f, 90f, 0f);
	}
}
