using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RightButton : MonoBehaviour
{

    public GameObject buttonObj;
    private float angle;
    [SerializeField] public Transform target;
    private bool buttonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonObj = GameObject.Find("Right-VirtualButton");
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        buttonPressed = true;
        FixedUpdate();
        Debug.Log("right is pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        buttonPressed = false;
        FixedUpdate();
        Debug.Log("right is released");
    }

    void FixedUpdate()
    {
        if (buttonPressed)
        {
            angle += 0.05f;

            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
            target.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }
}