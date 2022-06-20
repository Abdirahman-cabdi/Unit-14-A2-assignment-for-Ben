using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public GameObject logo1;

    public Transform Spawn2;

    public Transform Spawn1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition; //get mouse click position
            mousePos.z = Camera.main.nearClipPlane; 
            Vector3 Worldpos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 Worldpos2D = new Vector2(Worldpos.x, Worldpos.y);  // create a 2d vector for where a person clicked

            GameObject emptyGO = new GameObject(); // create a game object and transform to set the position for a new object
            Transform newTransform = emptyGO.transform;

            newTransform.transform.position = new Vector3(Worldpos2D.x, Spawn1.transform.position.y, Spawn1.transform.position.z); // updating the transform with mouse x click position
            Instantiate(logo1, newTransform); //create a new fab at the spawn positition
        }
    }

}
