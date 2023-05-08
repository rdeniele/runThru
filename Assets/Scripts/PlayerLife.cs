using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    public int HP = 3 ;
    [SerializeField] private Text HPTxt;
    // private Animator anim;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource collectSoundEffect;

    public GameObject gameOverUI;
    private bool isDead;
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            gameOver();
     
        }

        if (collision.gameObject.CompareTag("junkFood")) //check the tag of your game object being setted and type inside ""
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            playerMinusHP();


        }
    }

    /*private void Die()
    {
     //   deathSoundEffect.Play();
        rb.bodyType =RigidbodyType2D.Static;
     //   anim.SetTrigger("death");
    }
   */
    private void RestartLvl()
    {
        SceneManager.LoadScene(1); //change index to gameover if done
    }
    public void gameOver()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        gameOverUI.SetActive(true);
        anim.SetBool("run", false);
    }
    public void playerMinusHP()
    {
        HP--;
        HPTxt.text = "Player Life: " + HP;

        Debug.Log("HP: " + HP);
        if (HP <= 0 && !isDead)
        {

            isDead = true;
            gameOver();
        }
    }

    public void playerAddHP()
    {
         HP++;
        HPTxt.text = "Player Life: " + HP;

        Debug.Log("HP: " + HP);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit")) //check the tag of your game object being setted and type inside ""
            collectSoundEffect.Play();
        Destroy(collision.gameObject);
        playerAddHP();

    }


}
