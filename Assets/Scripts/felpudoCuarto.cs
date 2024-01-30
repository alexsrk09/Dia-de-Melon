using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class felpudoCuarto : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private GameObject teleport;
    void Update()
    {
        // find GameManager
        if (GameObject.Find("GameManager").GetComponent<GameManager>().telf == true)
        {
            // block set active false
            block.SetActive(false);
            // teleport set active true
            teleport.SetActive(true);
        }

        else
        {
            // block set active true
            block.SetActive(true);
            // teleport set active false
            teleport.SetActive(false);
        }
    }
}
