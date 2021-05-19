using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackwardsButton : MonoBehaviour
{

    public GameObject buttonObj;
    [SerializeField] float speed = 0.5f;
    [SerializeField] public Transform target;
    private bool buttonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonObj = GameObject.Find("Backwards-VirtualButton");
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        buttonPressed = true;
        FixedUpdate();
        Debug.Log("backwards is pressed");
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        buttonPressed = false;
        FixedUpdate();
        Debug.Log("backwards is released");
        
    }

    void FixedUpdate()
    {
        if (buttonPressed)
        {
            target.transform.position -= (speed * 0.1f) * target.transform.forward;
        }
    }
}
