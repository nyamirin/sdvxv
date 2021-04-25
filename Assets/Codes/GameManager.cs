using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //싱글톤
    public static GameManager instance =null;
    private void Awake(){
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance!=this) Destroy(this.gameObject);
    }
    
    public GameObject gameBoard;
    public Note noteprefab;
    public Note[][] chart = new Note[4][];
    public float falling_speed;

    void Start()
    {
        falling_speed=6;
    }

    void Update()
    {
        
    }
}
