using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ChestScript : MonoBehaviour
{

    private SpriteRenderer renderer;
    public Sprite chestOpenImage, chestClosedImage;

    void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
        renderer.sprite = chestOpenImage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            openChest();
        }
    }

    private void openChest()
    {
        renderer.sprite = chestClosedImage;
        // Give something to the player
    }
}
