using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject player;
    
    public float speedRotation = 2.0F;
    public int speed = 5;
    public AnimationClip anima;
    public int jumpSpeed = 50;

    
    // Use this for initialization
    void Start()
    {
        player = (GameObject)this.gameObject;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)){
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }

        float h = speedRotation * Input.GetAxis("Mouse X");
        float v = speedRotation * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);

    }

}
