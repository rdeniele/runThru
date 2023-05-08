using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMult;

    public float score;
    public Text scoreUI;
 
    // Update is called once per frame
    void Update()
    {

        scoreUI.text = score.ToString("000000");
        score += Time.deltaTime * 5f; ;
        speedMult += Time.deltaTime*0.1f;
        timer += Time.deltaTime;
        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum= Random.Range(0,3);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }

       

    }

   
}
