using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCollisionTester : MonoBehaviour{
    [SerializeField] private string objectTag = ""; public string ObjectTag{set => objectTag = value;}
    [SerializeField] private bool objectCollided = false; public bool ObjectCollided{get => objectCollided;}
    [SerializeField] private bool objectStayed = false; public bool ObjectStayed{get => objectStayed;}

    void OnCollisionEnter2D(Collision2D other){
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == objectTag){
            objectCollided = true;
        }
    }

    void OnCollisionStay2D(Collision2D other){
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == objectTag){
            objectStayed = true;
        }else{
            objectStayed = false;
        }
    }
}