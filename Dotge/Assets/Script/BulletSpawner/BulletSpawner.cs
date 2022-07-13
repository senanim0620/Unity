using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    float senaTime = 0;
    float ran;
    float rote;
    private void Start()
    {
        rote = 0;
        ran = Random.Range(1.0f, 2.0f);
    }
    //float ran = Random.Range(1.0f, 2.0f);

    bool sena = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(sena ==true)
        {
            senaTime += Time.deltaTime;

            // 숫자를 가변으로 해보래. 난 모르겠는데

            if (senaTime > ran)
            {
                Debug.Log("senanim");
                senaTime = 0;
                GameObject bullet = Instantiate(BulletPrefab, transform);
                bullet.transform.LookAt(Player);
                ran = Random.Range(1.0f, 2.0f);
            }
        }
        else
        {
            gameObject.transform.Rotate(0,Time.deltaTime,0);
        }


    }


    private void OnTriggerStay(Collider other)
    {
        sena = true;

    }


    private void OnTriggerExit(Collider other)
    {
        sena = false;

    }
}
