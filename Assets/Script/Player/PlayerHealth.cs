using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	private int totalHealth;
	[Header("FX Vida")]
	private AudioSource fxHealth;
	public AudioClip _RegHP;
	public AudioClip _Hit;
	public GameObject[] hearts;

	private int health;

	private SpriteRenderer _renderer;

	private Animator _animator;
	float timePass = 0f;
	int cant = 0;
	

	private void Awake()
	{
		//totalHealth = GameManager.instance.saveData.playerData.vitality;
		//totalHealth = 20;
		_renderer = GetComponent<SpriteRenderer>();
		_animator = GetComponent<Animator>();
		fxHealth = GetComponent<AudioSource>();
	}

	void Start()
	{
        if (GameManager.instance)
        {
			totalHealth = health;
        }
        else
        {
			health = 20;
			totalHealth = health;
		}

	}

}
