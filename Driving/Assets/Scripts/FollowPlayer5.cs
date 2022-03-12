using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer5 : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset = new Vector3(0, 9, -9);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 9, -9);
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
