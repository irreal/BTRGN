using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CreateLine : MonoBehaviour
{
    [Range(3, 360)]
    public int PointCount = 72;
    public float Radius = 1300f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var lr = GetComponent<LineRenderer>();
        lr.SetVertexCount(PointCount+1);
        for (int i = 0; i <= PointCount; i++)
        {
            var ratio = (float)i / (float)PointCount;
            var x = Radius * Mathf.Cos((2 * Mathf.PI) * ratio);
            var z = Radius * Mathf.Sin((2 * Mathf.PI) * ratio);
            lr.SetPosition(i, new Vector3(x, transform.position.y, z));
        }
        
    }
}
