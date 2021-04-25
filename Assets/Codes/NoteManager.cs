using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    //public int bpm=0;
    public double currentTime=0d;
    [SerializeField] Note noteprefab = null;
    
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            Make_Note(0,6,Time.time+1);
        }

    }

    Note Make_Note(int pos, float sp, double time){
        Note t_note = Instantiate(noteprefab, new Vector3(-0.225f+0.15f*pos,0.001f,20), Quaternion.identity);
        t_note.Set(sp, time);
        return t_note;
    }
}
