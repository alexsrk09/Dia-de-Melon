using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    [SerializeField] private float tpx; // teleport x
    [SerializeField] private float tpy; // teleport y
    [SerializeField] private float tpz; // teleport z
    [SerializeField] private float rot; // rotation
    // on trigger enter
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the other object is the player
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Teleporting");
            // teleport the player to the other side of the map
            other.gameObject.transform.position = new Vector3(tpx, tpy, tpz);
            // rotate the player to face the other direction
            other.gameObject.transform.rotation = Quaternion.Euler(0, 0, rot);
        }
    }
}
