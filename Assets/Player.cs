using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int strength;
    public int speed;
    public int luck;
    public int defense;
    public int score;

	public void SavePlayer()
    {
		SaveSystem.SavePlayer(this);
    }

	public void LoadPlayer()
	{
		PlayerData pd = SaveSystem.LoadPlayer();
		maxHealth = pd.MaxHealth;
		currentHealth = pd.CurrentHealth;
		strength = pd.Strength;
		speed = pd.Speed;
		luck = pd.Luck;
		defense = pd.Defense;
		score = pd.Score;

		Vector3 position = new Vector3 (pd.Position[0], pd.Position[1], pd.Position[2]);
		this.transform.position = position;
	}



	public void AddHealth(int amount)
	{
		currentHealth += amount;
		if (currentHealth > maxHealth) // Max Health
		{
			currentHealth = maxHealth;
		}
		Debug.Log("Player got some life. His current health is " + currentHealth);
	}


}
