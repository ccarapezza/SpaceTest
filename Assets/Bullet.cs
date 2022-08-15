using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    private SpriteRenderer spriteRenderer;
    private bool shooted = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!shooted && spriteRenderer.isVisible){
            shooted = true;
        }

        if (!shooted)
            return;

        if (spriteRenderer.isVisible)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
