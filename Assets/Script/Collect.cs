using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggertEnter(Collider other){
        if (other.tag == Sphere){
            Debug.Log("HEY")
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
