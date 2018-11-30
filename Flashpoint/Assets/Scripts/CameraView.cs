using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {
    public Transform Player; //Position of the player
    private Vector3 deltaPos; //Position of the camera
    
    // Use this for initialization
    void Start () {
        deltaPos = new Vector3(2, 30, -12);
        Vector3 pos = Player.TransformDirection(deltaPos);
        transform.position = Player.position + pos;
        Vector3 playerPos = Player.position + new Vector3(2, 2, 0);
        transform.LookAt(playerPos);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
