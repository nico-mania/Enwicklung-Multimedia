using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    public Transform BetterCoin;
    int randomX;
    int randomZ;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            int randomX = UnityEngine.Random.Range(-43, 43);
            int randomZ = UnityEngine.Random.Range(-43, 43);
            Instantiate(BetterCoin, new Vector3(randomX, 1.5f, randomZ), Quaternion.Euler(90f, 0f, 90f));
            Debug.Log(randomX & randomZ);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
