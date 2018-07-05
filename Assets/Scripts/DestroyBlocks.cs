using UnityEngine;
using System.Collections;

public class DestroyBlocks : MonoBehaviour {

    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("yes");
            Destroy(gameObject);
        }
    }
}
