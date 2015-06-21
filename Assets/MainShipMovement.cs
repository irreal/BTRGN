using UnityEngine;
using System.Collections;

public class MainShipMovement : MonoBehaviour {
    public float MovementSpeed = 200f;
    public float MaximumHeight = 450f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().maxAngularVelocity = 1;
	}
	
	// Update is called once per frame
	void Update () {
        var horizontalAxis = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().AddTorque(0f, -horizontalAxis * MovementSpeed * Time.deltaTime, 0f);

        transform.Translate(0f, Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0f);
        if (transform.position.y < -MaximumHeight)
        {
            var position = transform.position;
            position.y = -MaximumHeight;
            transform.position = position;
        }
        else if (transform.position.y > MaximumHeight)
        {
            var position = transform.position;
            position.y = MaximumHeight;
            transform.position = position;
        }

	}
}
