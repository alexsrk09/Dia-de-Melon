using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niato : MonoBehaviour
{
    [SerializeField] private GameObject niato;
    void Update()
    {
        Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().chestOpenend);
        if (GameObject.Find("GameManager").GetComponent<GameManager>().chestOpenend) niato.SetActive(true);
        else niato.SetActive(false);
    }
}
