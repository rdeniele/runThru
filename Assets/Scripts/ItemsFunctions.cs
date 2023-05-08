using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemsFunctions : MonoBehaviour
{
   
    private int Fruit = 0;
    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private Text fruitsText;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit")) //check the tag of your game object being setted and type inside ""
        collectSoundEffect.Play();
        Destroy(collision.gameObject);
        Fruit++;
        
        fruitsText.text = "Fruits: "+Fruit;
       
        Debug.Log("Fruit(s): " + Fruit);

    }
}
