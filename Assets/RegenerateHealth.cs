using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerateHealth : MonoBehaviour
{
	int total = 0;
	int hp = 0;
	int aux = 0;
	float timePass = 0f;
	public GameObject _Hearts;
    private void Update()
    {
		

		if (hp < total-1)
        {
			aux = total - hp;

			if(aux < total)
            {
				if(Time.time > timePass)
                {
					_Hearts.GetComponent<HeartLogic>().Heal(2);
					Debug.Log("Vida enviada");
                }
            }
        }
    }
}
