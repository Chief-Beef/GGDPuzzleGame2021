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

    public float timerReset;
    public float timer;
    
    public bool teleport;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Physics.Raycast(ray);
       

        if (Physics.Raycast(ray, out hit))
        {
            hitObject.position = hit.point;

        }


        if (Input.GetKeyDown(KeyCode.Mouse0) && timer <= 0)
        {
            player.transform.position = hitObject.position;
            RigidBodyMove.Instance.rb.velocity = new Vector3(0, 0, 0);
            timer = timerReset;
        }


    }


}





