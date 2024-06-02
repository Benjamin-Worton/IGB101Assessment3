using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaDeath : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {      
            SceneManager.LoadScene("Tamika R. Dragon's Den");
         
        }
    }
}
