using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicStoneAmount : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("FX Coin")]
    private AudioSource fxCoin;
    public AudioClip coin;
    public GameObject _Magic_Stone;

    private void Start()
    {
        fxCoin = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            fxCoin.PlayOneShot(coin);
            Destroy(gameObject, 0.3f);
            
        }
    }


    

    
}
