using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndClick : MonoBehaviour
{

    //Effect and Cause

    public Transform hitObject;
    public GameObject marker;
    public GameObject player;

    public bool teleport;

    // Start is called before the first frame update
    void Start()
    {
        teleport = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        //activating and deactivating teleporter gun

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Physics.Raycast(ray);


        //active teleport gun
       

        if (Physics.Raycast(ray, out hit))
        {
            hitObject.position = hit.point;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Teleport();
        }

      
       

    }

    public void Teleport()
    {

        Debug.Log("hitObject: " + hitObject.transform.position + "this position: " + this.transform.position );

        player.transform.position = hitObject.transform.position;

    }




}





