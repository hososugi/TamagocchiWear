using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenImage : MonoBehaviour
{
    void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        float cameraHeight = Camera.main.orthographicSize * 2;
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;

        Vector2 scale = transform.localScale;

        // Landscape (or equal)
        if (cameraSize.x >= cameraSize.y)
            scale *= cameraSize.x / spriteSize.x;
            scale *= cameraSize.y / spriteSize.y;

        // Optional
        transform.position = Vector2.zero;
        transform.localScale = scale;
    }
}
