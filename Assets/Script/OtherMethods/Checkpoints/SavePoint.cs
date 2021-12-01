using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePoint : MonoBehaviour
{
    public GameObject _TriggerEffect;
    public GameObject _HUD;
    public GameObject _Player;

    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.CompareTag("Trap"))
        {
            if(collision.gameObject.CompareTag("Player"))
            {

            }  
        }
    }

}
