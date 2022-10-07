using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appletree : MonoBehaviour {
public static float bottomY = -20f;
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject ApplePrefab;
   
    // Speed at which the AppleTree moves
    public float speed = 1f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    void Start(){
        InvokeRepeating("DropApple", 1f,secondsBetweenAppleDrops);
    }

    void Update()
    {
        Vector3 pos = transform.position; // b
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        pos.x += speed * Time.deltaTime;
        pos.x += 1.0f * 0.02f;
        pos.x += 0.02f;

        if (pos.x < -leftAndRightEdge)
        {

            speed = Mathf.Abs(speed);
        } // Move right // b 

            else if (pos.x > leftAndRightEdge)
            { // c
            speed = -Mathf.Abs(speed); // Move lef
            }

    }
         
    
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        { // b
            speed *= -1; // Change direction
        }
    }

    void DropApple()
    { // b
        GameObject Apple = Instantiate<GameObject>(ApplePrefab); // c
        Apple.transform.position = transform.position; // d
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

       
}




