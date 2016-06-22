using UnityEngine;
using System.Collections;

public class RotatingObject : MonoBehaviour {

    private Transform thisTransform;
    private float speed = 20;

    void Start () {
        thisTransform = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
        thisTransform.Rotate(Vector3.right * Time.deltaTime * speed);
        thisTransform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}
