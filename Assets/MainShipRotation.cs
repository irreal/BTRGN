using UnityEngine;
using System.Collections;

public class MainShipRotation : MonoBehaviour {
    public GameObject OrbitObject;
    private float RotationOffsetFromOrbit = 90f;
    private float rotation = 90f;
    private float lastSwitchTime;
    private float rotationTime = 0.4f;
    public int Direction
    {
        get
        {
            return RotationOffsetFromOrbit == 90f ? 1 : -1;
        }
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(OrbitObject.transform);
        var horizontalAxis = Input.GetAxis("Horizontal");

        if (horizontalAxis > 0)
        {
            SetRotation(90f);
        }
        else if (horizontalAxis < 0)
        {
            SetRotation(270);
        }
        var angle = Mathf.Lerp(rotation, RotationOffsetFromOrbit, (Time.time - lastSwitchTime) / rotationTime);
        if (angle == RotationOffsetFromOrbit)
        {
            rotation = RotationOffsetFromOrbit;
        }
        transform.Rotate(0f, angle, 0f);
	}

    private void SetRotation(float angle)
    {
        if (RotationOffsetFromOrbit != angle)
        {
            lastSwitchTime = Time.time;
        }
        RotationOffsetFromOrbit = angle;
    }
}
