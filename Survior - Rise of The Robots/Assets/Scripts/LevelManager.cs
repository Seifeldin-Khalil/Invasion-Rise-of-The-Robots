using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject CurrentCheckpoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void respawnplayer()
    {
        FindObjectOfType<PlayerMovement>().transform.position = CurrentCheckpoint.transform.position;
        
    }

}