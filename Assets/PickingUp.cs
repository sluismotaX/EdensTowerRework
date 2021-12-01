using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public GameObject ob;
    public GameObject _player;
    private Animator _player_animator;


    private void Awake()
    {
        _player_animator = _player.GetComponent<Animator>();
    }
    public void addItem()
    {
    }
    
}
