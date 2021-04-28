using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario_Move : MonoBehaviour
{
   
    
    [SerializeField] float speed = 0.5f;
    public float angle = 0;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        angle += horizontal * speed * Time.deltaTime;
        transform.position += vertical * (speed * 0.1f) * transform.forward;
        transform.rotation = Quaternion.LookRotation(new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)));
    }
}
