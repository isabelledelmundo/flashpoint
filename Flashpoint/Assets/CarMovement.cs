using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {
    private Transform Car;
    // Use this for initialization
    void Start()
    {
        Car = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Car.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Car.Rotate(Vector3.up * -90);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Car.Rotate(Vector3.up * 90);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Car.Rotate(Vector3.up * 180);
        }
    }
}
