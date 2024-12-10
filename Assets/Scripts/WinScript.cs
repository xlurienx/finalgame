using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisioEnter2D(Collider2D collision)
    {
        Debug.Log("WIN!!!");
        SceneManager.LoadScene(1);
    }
}
