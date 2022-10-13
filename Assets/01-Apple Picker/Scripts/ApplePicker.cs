using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject BasketPrefab;
    public int numBaskets = 3;
    public float BasketBottomY = -14f;
    public float BasketSpacingY = 2f;
    public List<GameObject> BasketList;

    void Start()
    {
        BasketList = new List<GameObject>();
        for (int i = 0; i<numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(BasketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = BasketBottomY + (BasketSpacingY * i);
            tBasketGO.transform.position = pos;
            BasketList.Add(tBasketGO);
        }
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }

        // Destroy one of the baskets // e
        // Get the index of the last Basket in basketList
        int basketIndex = BasketList.Count - 1;
        // Get a reference to that Basket GameObject
        GameObject tBasketGO = BasketList[basketIndex];
        // Remove the Basket from the list and destroy the GameObject
         BasketList.RemoveAt(basketIndex);
          Destroy(tBasketGO);
        if (BasketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0"); // a
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
