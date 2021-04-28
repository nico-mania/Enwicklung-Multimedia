using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Rotate : MonoBehaviour
{
    float rotateCoin = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateCoin++;
        this.transform.rotation =  Quaternion.Euler(new Vector3(90f, rotateCoin, 90f));
        Debug.Log(rotateCoin);
        if(rotateCoin == 360f)
        {
            rotateCoin = 0f;
        }
    }
}
