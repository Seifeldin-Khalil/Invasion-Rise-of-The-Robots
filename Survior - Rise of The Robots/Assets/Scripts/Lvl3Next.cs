using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl3Next : MonoBehaviour
{
    // Start is called before the first frame updat
    void loadover()
    {
        SceneManager.LoadScene("Scene1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            loadover();
        }

    }
}
