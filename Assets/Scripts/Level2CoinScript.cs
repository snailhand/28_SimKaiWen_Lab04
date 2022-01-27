using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2CoinScript : MonoBehaviour
{
    public float SpinSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, SpinSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (transform.parent.childCount <= 1)
            {
                SceneHandler.WinGame();
            }
            var player = other.gameObject.GetComponent<PlayerMovement>();
            player.UpdateScore();

            Destroy(this.gameObject);
        }
    }
}
