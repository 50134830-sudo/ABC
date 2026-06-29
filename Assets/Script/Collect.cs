using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject Cubo;
    public GameObject playerPickUpRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
         if (other.CompareTag("PickUp")){
            Debug.Log("collision");

            if(Input.GetKeyDown(KeyCode.E)){        
                Debug.Log("HEY");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
