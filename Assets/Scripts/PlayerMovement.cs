using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    int coinCount;
    Text coinText;
    Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        coinText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveY);
        playerRb.AddForce(movement * moveSpeed * Time.deltaTime);
    }

    public void UpdateScore()
    {
        coinCount++;
        coinText.text = "Score: " + coinCount.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            SceneHandler.LoseGame();
        }
    }
}
