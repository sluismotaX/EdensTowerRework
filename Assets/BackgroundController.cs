using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float scrollingSpeed = 0.1f ,currentTempSpeed;
    public MeshRenderer renderer;
    private Vector2 currentPosition;
    // Start is called before the first frame update


    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTempSpeed = scrollingSpeed * (110 / gameObject.transform.position.z);
        currentPosition.x = currentPosition.x + currentTempSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPosition;
    }
}
