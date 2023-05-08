using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLoop : MonoBehaviour
{
    public float scrollSpeed=0.5f;
    //update
    void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime, 0);

        if (transform.position.x< -52.1)
        {
            transform.position = new Vector3(108.3f, transform.position.y, 0);
        }
    }
}
