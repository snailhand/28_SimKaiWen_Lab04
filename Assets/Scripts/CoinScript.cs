using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float SpinSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, SpinSpeed * Time.deltaTime));
    }
}
