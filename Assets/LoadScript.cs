using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour
{
    public bool isPlayed;
    public GameObject resumeButton;
    public GameObject classicButtons;

    // Start is called before the first frame update
    void Start()
    {
        Transform Transform1 = classicButtons.GetComponent<Transform>();
        if (isPlayed)
        {
            resumeButton.SetActive(true);
            Transform1.position = new Vector3(transform.position.x,transform.position.y - 50,transform.position.z);

        }
        else
        {
            resumeButton.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
