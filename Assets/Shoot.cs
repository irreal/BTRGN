using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject Bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            var bContainer = Instantiate(Bullet);
            bContainer.transform.position = Vector3.zero;
            var bullet = bContainer.transform.GetChild(0);
            bullet.transform.position = transform.position;
            var dir = GetComponent<MainShipRotation>().Direction;
            bContainer.GetComponent<BulletMovement>().BulletSpeed *= dir;
        }
	}
}
