using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript: MonoBehaviour {
    void OnCollisionEnter(Collision other)
    {

        // Destroy everything that leaves the trigger
        if (other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            Debug.Log("hit");
            Destroy(this.gameObject);

        }

    }
}
