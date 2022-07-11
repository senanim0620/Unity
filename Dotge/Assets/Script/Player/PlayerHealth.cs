using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Die();   
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
