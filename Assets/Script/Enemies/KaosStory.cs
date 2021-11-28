using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaosStory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startRoom;
    private Rigidbody2D _rigidbody;
    Animator _animator;
    public GameObject firstPartFinished;
    private int flipThisStuff=0;


    void Start()
    {
         _animator = this.GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void LateUpdate() 
    {
        _animator.SetBool("idle", _rigidbody.velocity == Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(flipThisStuff==1){
            flip();
            
        }
        if(startRoom.activeSelf){
            if(transform.position.x>267.4){
               
                _rigidbody.velocity = new Vector2(-2.5f, _rigidbody.velocity.y);
            }
        }
        if(firstPartFinished.activeSelf){
            if(transform.position.x<303.9){
                if(flipThisStuff<5){
                    flipThisStuff++;}
                _rigidbody.velocity = new Vector2(3f, _rigidbody.velocity.y);
            }
            else{
                _rigidbody.velocity=Vector3.zero;
            }
        }
    }
    public void flip() //Makes the enemy face the other way 
    {
        //facingRight = !facingRight;
        float localScaleX = transform.localScale.x;
        localScaleX = localScaleX * -1f;
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
}
