using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadover()
    {
        SceneManager.LoadScene("Scene1");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        loadover();
    }
}