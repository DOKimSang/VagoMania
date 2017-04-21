using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float speed = 15.0f;
    public float speedRot = 5.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
        this.transform.rotation *= Quaternion.AngleAxis(speedRot * Input.GetAxis("Horizontal"), Vector3.up);
    }
}