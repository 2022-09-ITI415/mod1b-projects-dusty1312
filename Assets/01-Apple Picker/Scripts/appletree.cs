using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Appletree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject ApplePrefab;
    public GameObject greenapplePrefab;
    // Speed at which the AppleTree moves
    public float speed = 5f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 20f;
    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.2f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;
    void Start()
    {
        // Dropping apples every second
    }
    void Update()
    {
        Vector3 pos = transform.position; // b
        pos.x += speed * Time.deltaTime;
        pos.x += 1.0f * 0.04f;
        pos.x += 0.04f;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right // b
        }
        else if (pos.x > leftAndRightEdge)
        { // c
            speed = -Mathf.Abs(speed); // Move lef
        }
        else if (Random.value < chanceToChangeDirections)
        { // a
            speed *= -1;
        }
    }
}