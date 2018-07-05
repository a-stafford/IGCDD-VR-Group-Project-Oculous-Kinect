using UnityEngine;
using System.Collections;

public class HandShoot : MonoBehaviour {
    public GameObject rightBullet, leftBullet, bulletSpawn, bulletSpawn1;
    public float rightShotDelay = 0.95f, leftShotDelay = 0.65f;
    float shotCooldownLeft = 0;
    float shotCooldownRight = 0;


    void Update() {
        shotCooldownLeft -= Time.deltaTime;
        shotCooldownRight -= Time.deltaTime;
    }
    void OnCollisionStay(Collision other)
    {

        if (other.gameObject.CompareTag("RightHand") && shotCooldownRight <= 0)
        {
            Debug.Log("Right Shot fired");
            Instantiate(rightBullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            shotCooldownRight = rightShotDelay;
            
            Debug.Log("yes");
        }

        if (other.gameObject.CompareTag("LeftHand") && shotCooldownLeft <= 0)
        {
            Debug.Log("Left Shot fired");
            Instantiate(leftBullet, bulletSpawn1.transform.position, bulletSpawn1.transform.rotation);
            shotCooldownLeft = leftShotDelay;
            Debug.Log("yes yes");
        }

        

    }


}
