using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public mindScript mind;

    void OnMouseDown()
    {
        mind.ChangePlayer(this.gameObject);
        GetComponent<PlayerController>().enabled = true;
    }
}
