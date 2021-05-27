using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll1 : MonoBehaviour
{

    public float velScroll = 0.1f;
    public Renderer quad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 offset = new Vector2(velScroll * Time.deltaTime, 0);
        quad.material.mainTextureOffset += offset;

    }
}
