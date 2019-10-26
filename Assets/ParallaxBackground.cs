using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Vector2 startPosition;
    private float updatePosition;

    public float scrollSpeed;
    public Renderer backgroundRender;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        backgroundRender.material.mainTextureOffset += new Vector2(0, scrollSpeed * Time.deltaTime);
    }
}
