using UnityEngine;
using System.Collections;

public class DieAfterTimeout : MonoBehaviour {
    public float SecondsToWait;
    private float startTime;
	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > startTime + SecondsToWait)
        {
            Destroy(gameObject);
        }
	}
}
