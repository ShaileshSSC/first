using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    public Transform bulletpos;
    private float bulletSpeed = 5;
    public GameObject bulletPrefab;
    private bool shoot = true;
    private int timer = 0;

    // Use this for initialization
    void Start () {
		
	}

    float speed = 10.0f;
    float speed2 = 200.0f;


    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.Translate(0, 0, input);
        float input2 = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed2;
        transform.Rotate(0, input2, 0);
        if (Input.GetKeyDown("space"))
        {
            Schiet();
            transform.localScale += new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKeyUp("space"))
        {
            transform.localScale += new Vector3(0, 0, 0.1f);

        }


    }

    void Schiet()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletpos.position,
            bulletpos.rotation);


        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 200;


        Destroy(bullet, 1.5f);
    }
}
