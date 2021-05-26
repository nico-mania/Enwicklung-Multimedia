using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    

    [SerializeField] public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + ((Quaternion.Slerp(player.transform.rotation, transform.rotation, 2)) * offset);
        transform.rotation = player.transform.rotation * Quaternion.Euler(20, 0, 0);
    }
}
