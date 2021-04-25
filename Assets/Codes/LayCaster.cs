using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayCaster : MonoBehaviour
{
    public RaycastHit hit;
    public float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,Vector3.forward*speed*0.05f,Color.blue);
        if(Physics.Raycast(transform.position,Vector3.forward, out hit, speed*0.3f)){
        }
        if(Input.GetKeyDown(KeyCode.S)){
            double min=hit.hittime-Time.time;
            if(-0.005<=min||min<=0.005) Debug.Log("Critical"+min);
            else Debug.Log(min);
        }
    }
}
