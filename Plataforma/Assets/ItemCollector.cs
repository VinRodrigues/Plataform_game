using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int acorn = 0;

    [SerializeField] private Text acornText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Acorn"))
        {
           collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            acorn++;
            acornText.text = ": " + acorn;
        }
    }
}