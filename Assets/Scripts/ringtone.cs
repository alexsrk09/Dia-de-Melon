using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ringtone : MonoBehaviour
{
    public GameObject player;
    public float distanciaMaxima = 10f;
    public AudioSource audioSource; // Declare the AudioSource variable

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GetComponent<AudioSource>(); // Assuming the AudioSource is attached to the same GameObject
    }

    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().telf)
        {
            // disable the audio source
            audioSource.enabled = false;
        }
    }
}