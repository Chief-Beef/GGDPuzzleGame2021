using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LandMine : MonoBehaviour
{

    public GameObject blueStuff;
    


    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Explosion");
            Destroy(this.gameObject);
            //Death Stuff
            SceneManager.LoadScene("Lose");


        }
    }

}
