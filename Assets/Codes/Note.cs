using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    float speed=6;
    bool set=false;
    double hittime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(!set)return;
        Fall();
    }

    void Fall(){
        transform.position+=Vector3.forward*-1f*speed*Time.deltaTime;
    }

    public void Set(float sp, double time){
        speed=sp;
        Vector3 temp=transform.position;
        temp.z=((float)time-Time.time)*speed;
        transform.position=temp;
        hittime=time;
        set=true;
    }
}
