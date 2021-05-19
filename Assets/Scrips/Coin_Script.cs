using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    public Transform coinPrefab;
    int randomX;
    int randomZ;
    public Transform parent;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            int randomX = UnityEngine.Random.Range(-43, 43);
            int randomZ = UnityEngine.Random.Range(-43, 43);
            Instantiate(coinPrefab, new Vector3(randomX, 23f, randomZ), Quaternion.Euler(0f, 0f, 90f), parent);
            Debug.Log(randomX & randomZ);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
