using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

[SerializeField] float speed;
















    
    void Update()
    {
        transform.Translate(0,0, speed * Time.deltaTime);

        //tuhotaan Enemy, kun se menee pois screeniltÃ¤, eli kun z < -7
        if(transform.position.z < -7f)
        {
            GameManager.gameManager.Scoreup();


            Destroy(gameObject);
        }

    }
}
