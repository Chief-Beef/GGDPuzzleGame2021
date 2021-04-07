using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextScript : MonoBehaviour
{

    public Text txt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = RigidBodyMove.Instance.keys + "/4 Keys";

        if(RigidBodyMove.Instance.keys == 4)
        {
            SceneManager.LoadScene("Win");

        }

    }


}
