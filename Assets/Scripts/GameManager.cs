using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int isPaused;

    public float victoryPoints;
    public float playerHealth = 20;
    public float money = 10;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<SaveSystem_Script>().SaveData();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<SaveSystem_Script>().LoadData();
        }
    }
}
