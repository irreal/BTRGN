using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {
    public float Health = 100;
    public GameObject Explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Health -= 10;
        if (Health <= 0)
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(gameObject.transform.parent.gameObject);
            
        }
    }
}
