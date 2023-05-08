using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform Player;
    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y,transform.position.z);
    }
}
