using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimiento_paulo : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       transform.position = new Vector3 (player.position.x, player.position.y, transform.position.z);

    }
}
