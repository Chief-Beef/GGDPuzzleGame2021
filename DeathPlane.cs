using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathPlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            //Death Stuff
            SceneManager.LoadScene("Lose");

        }
    }


}
