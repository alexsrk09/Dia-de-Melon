using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool telf = false;
    public bool key = false;
    public bool chestOpenend = false;
    public KeyCode interactKey = KeyCode.E;


    private void Update() {
        // if player is near phone and press interact key
        if (Vector2.Distance(GameObject.FindWithTag("Player").transform.position, GameObject.Find("telefono_fijo").transform.position) < 0.5f
        && Input.GetKeyDown(interactKey))telf = true;

        // if player is near chest and press interact key
        if (Vector2.Distance(GameObject.FindWithTag("Player").transform.position, GameObject.Find("Cofre").transform.position) < 0.4f
        && Input.GetKeyDown(interactKey)
        && key) chestOpenend = true;

        // if player is near key and press interact key
        if (Vector2.Distance(GameObject.FindWithTag("Player").transform.position, GameObject.Find("HotDogs").transform.position) < 0.7f
        && Input.GetKeyDown(interactKey)) key = true;
    }
}
