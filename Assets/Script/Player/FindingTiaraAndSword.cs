using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FindingTiaraAndSword : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tiara;
    private int veces;
    private PlayerControllerV2 playerMainScript;
    public Transform textPlayerBox;
    public Text dialogPlayerText;
    public Transform sword;
    
    public Transform textPlayerBoxSword;
    public Text dialogPlayerTextSword;
    private Animator _animation;
    
    void Start()
    {
        playerMainScript=gameObject.GetComponent<PlayerControllerV2>();
        _animation=GetComponent<Animator>();
        veces=0;
        textPlayerBox.gameObject.SetActive(false);
        textPlayerBoxSword.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }

    

}
