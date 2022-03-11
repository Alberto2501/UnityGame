using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{

    [SerializeField]
    private bool gameRunning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeGameRunningState();
        }
    }

    public void ChangeGameRunningState()
    {
        gameRunning = !gameRunning;
        if (gameRunning)
        {
            //Game is running
            Debug.Log("Game Running");
        } else {
            //Game is paused
            Debug.Log("Game Paused");
        }


    }
}
