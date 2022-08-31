using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float rotX, rotY, rotZ, speedX, speedY, speedZ;
    
    //Väistelynopeus
    [SerializeField] float dodgeSpeed;

    [SerializeField] float maxX;
    
    
    
    //muuttuja liikkumiseen vasempaan ja oikeaan, x-akselilla
    float xInput;

    
    





    void Update()
    {
        

        float tempX = Input.acceleration.x;
        float tempZ = Input.acceleration.z;

        // kone liikkuu x -akselin suuntaisesti
        transform.Translate(tempX * speedX * Time.deltaTime, 0, 0);

        // kone liikkuu y -akselin suuntaisesti
        //transform.Translate(0, tempZ * speedY * Time.deltaTime, 0);

        // kone liikkuu z -akselin suuntaisesti
        //transform.Translate(0, 0, -tempZ * speedZ * Time.deltaTime);

        // kone kallistuu x -akselilla
        //transform.Rotate(-tempZ * rotX * Time.deltaTime, 0, 0 );

        // kone pyörii  y -akselin ympäri
        //transform.Rotate(0, tempX * rotY * Time.deltaTime, 0 );

        // kone kallistuu z -akselilla
        //transform.Rotate(0,0,-tempX * rotZ * Time.deltaTime); 


        //Liikutetaan pelaajaa nuolinäppäimillä
        float LimitedX = Mathf.Clamp(transform.position.x, -maxX, maxX);

        transform.position = new Vector3(LimitedX, transform.position.y, transform.position.z);

        
    }


    void OnTriggerEnter(Collider other)
    {
        GameManager.gameManager.Restart();
    }

    



}
