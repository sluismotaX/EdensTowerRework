using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    private int maxHealth;
    private int currentHealth;
    private int strength;
    private int speed;
    private int luck;
    private int defense;
    private int score;
    private float[] position;

    public PlayerData(Player p)
    {
        maxHealth = p.maxHealth;
        currentHealth = p.currentHealth;
        strength = p.strength;
        speed = p.speed;
        luck = p.luck;
        defense = p.defense;
        score = p.score;
        position = new float[3];
        position[0] = p.transform.position.x;
        position[1] = p.transform.position.y;
        position[2] = p.transform.position.z;
    }

    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Speed { get => speed; set => speed = value; }
    public int Luck { get => luck; set => luck = value; }
    public int Defense { get => defense; set => defense = value; }
    public int Score { get => score; set => score = value; }
    public float[] Position { get => position; set => position = value; }
}
