using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {
    public float BulletSpeed = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, -BulletSpeed * Time.deltaTime, 0f);
	}
}
