using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public float SpinSpeed;
    public int coinCount;
    Text coinText;

    private void Start()
    {
        coinText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, SpinSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            coinCount++;
            coinText.text = "Score: " + coinCount.ToString();
            Destroy(this.gameObject);
        }
    }
}
