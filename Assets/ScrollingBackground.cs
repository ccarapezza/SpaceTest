using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    public bool vertical = false;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 direction = vertical?Vector2.up:Vector2.right;
        Vector2 textureOffset = direction * Time.time * scrollSpeed;
        meshRenderer.material.mainTextureOffset = textureOffset;
    }
}
