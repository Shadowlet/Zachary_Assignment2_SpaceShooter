using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Vector2 startPosition;
    private float updatePosition;

    public float scrollSpeed;
    public float tileSize;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        updatePositon = Mathf.Repeat(Time.time * tileSize);
    }
}
