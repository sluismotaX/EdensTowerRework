using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class PlayerControllerV2 : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 2.5f;
    public Transform groundCheck;
    public LayerMask groundedLayers;
    public float groundCheckBaridus;
    private Rigidbody2D _body;
    private Animator _animator;


    private Vector2 _movement;
    private bool facingRight = true;
    public bool _isGrounded = true;
    private float counter = 0;

    private bool atacking = false;
    private int colPicas;

    private int veces;
    public int jumpsWanted;
    private bool isJumping = false;

    public Transform traps;

    private GameObject _target;
    public float minX;
    public float maxX;
    public float waitingTime = 2f;
    private bool pushing;

    private bool isGrounded;
    private bool enableKey;
    Scene currentScene;
    string sceneName;

    //Attack
    private bool isAttacking;
    public GameObject espada;
    public GameObject bow;

    [Header("Efectos de sonido")]
    private AudioSource playerSFX;
    public AudioClip _Walk;
    public AudioClip _Jump;
    public AudioClip _Attack;



    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        veces = 0;
        colPicas = 0;
        UpdateTarget();
        pushing = false;
        playerSFX = GetComponent<AudioSource>();
        enableKey = true;
    }
    private void UpdateTarget()
    {
        if (_target == null)
        {
            _target = new GameObject("Target");
            _target.transform.position = new Vector2(maxX, transform.position.y);
            return;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _animator.SetTrigger("Enter");
            }
        }
    }
    public void enableKeys(bool enable)
    {
        enableKey = enable;
        if (enable == false)
        {
            _movement = Vector3.zero;
        }

    }
}
    // Update is called once per frame
