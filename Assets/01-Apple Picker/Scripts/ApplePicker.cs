using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject BasketPrefab;
    public int numBaskets = 3;
    public float BasketBottomY = -14f;
    public float BasketSpacingY = 2f;

    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(BasketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = BasketBottomY + (BasketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
