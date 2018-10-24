using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSound : MonoBehaviour
{

    public AudioSource CoinSound;



    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {
        CoinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (gameObject.CompareTag("EndSound"))
        {
            CoinSound.Play();
        }
    }
}

