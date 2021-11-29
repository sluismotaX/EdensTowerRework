using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _body;
    private Animator _animator;
    private Player player;

    private Vector2 _movement;
    private bool facingRight = true;

    private bool atacking = false;

    void Awake()
    {
        player = GetComponent<Player>();
        _body = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (!atacking)
        {
            _movement = new Vector2(horizontalInput, 0f);
        }

        if (horizontalInput < 0f && facingRight)
        {
            flip();
        }
        else if (horizontalInput > 0f && !facingRight)
        {
            flip();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.SavePlayer();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.LoadPlayer();
        }
    }

    private void FixedUpdate()
    {
        float horizontalVelocity = _movement.normalized.x * player.speed;
        _body.velocity = new Vector2(horizontalVelocity, _body.velocity.y);
    }
    private void LateUpdate()
    {
        _animator.SetBool("Idle", _movement == Vector2.zero);
    }

    private void flip()
    {
        facingRight = !facingRight;
        float localScaleX = transform.localScale.x;
        localScaleX *= -1f;
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);

    }
}
