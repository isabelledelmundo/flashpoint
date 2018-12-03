using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceFirefighter : MonoBehaviour{

    public GameObject firefighter;
    public GameObject placeFirefighterPanel;
    public GameObject mainGamePanel;


    private void Start()
    {
        //launchPad = gameObject.GetComponent<Transform>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firefighter.SetActive(true);
            placeFirefighterPanel.SetActive(false);
            mainGamePanel.SetActive(true);

            Debug.Log("clicking");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray))
               //Instantiate(firefighter, transform.position, transform.rotation);
        }
    }
}

    //public void PlaceFirefighter()
    //{
    //    public Vector2 mousePos  = Input.mousePosition;

    //    //Depth you want the center of the object to be is z which I used zero
    //    public Vector3 boxPos = camera.ScreenToWorldPoint(mousePos.x, mousePos.y, 0);

    //    //I used the perfab box's rotation here but you can enter what you'd like as a euler using Quaternion.Euler(x,y,z)
    //    Instantiate(firefighter, boxPos, firefighter.transform.rotation);
    //}


