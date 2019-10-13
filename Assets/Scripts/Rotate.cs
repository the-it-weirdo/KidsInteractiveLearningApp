using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public int roatateSpeed = 50;
    public float touchRotateSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount == 0)
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * roatateSpeed, 0));
        }
	}

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * touchRotateSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * touchRotateSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
