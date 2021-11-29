using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
    public GameObject main;
    void end()
    {
        main.GetComponent<MenuController>().Back();
    }
}
