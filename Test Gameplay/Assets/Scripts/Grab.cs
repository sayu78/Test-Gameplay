using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    //Raycast
    public Transform handsPosition;
    public float distance = 10f;
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);

                if (hit.transform.gameObject.tag =="Ball")
                {
                    gameObject.GetComponent<Throw>().Ball = hit.transform.gameObject;
                    hit.transform.parent = this.transform;
                    hit.transform.position = handsPosition.transform.position;
                    hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }

         
        }
    }
}
