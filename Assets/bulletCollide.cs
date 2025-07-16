using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollide : MonoBehaviour


{
    GameObject player;

    void Start(){
        player = GameObject.Find("Main Camera");

        if (player == null){
            Debug.Log("null");

        }
        
    }

    void OnCollisionEnter(Collision collision){
        
            Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Main Camera"){
            Debug.Log("collision");


            player.GetComponent<killPlayer>().kill();
            Destroy(gameObject);
        }


        

    }



}
