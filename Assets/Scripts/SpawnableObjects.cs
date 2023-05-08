using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnableObjects : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private GameManager gm;
   

    private float timer;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer>6)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left *(speed + gm.speedMult);
    }
}
