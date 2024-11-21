using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    private static Game instance;
    [SerializeField] GameObject events;
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject player;

    void Awake(){
        DontDestroyOnLoad(this);
    }

    public Events GetEvents(){
        return events.GetComponent<Events>();
    }

    public GameManager GetGameManager(){
        return gameManager.GetComponent<GameManager>();
    }

    public PlayerController GetPlayer(){
        return player.GetComponent<PlayerController>();
    }

    public GameCollisionTester GetCollisionTester(){
        return player.GetComponent<GameCollisionTester>();
    }
}