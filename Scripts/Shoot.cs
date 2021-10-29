using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject Bullet;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    float timer = 10f;
    bool start = false;
    public float shootRate = 3f;
    void Update()
    {
        float shoot = Input.GetAxis("Fire1");
        if (shoot == 1 && timer >= shootRate)//shoot{
        {

            GameObject newProjectile = Instantiate(Bullet, transform.position + transform.forward, transform.rotation);
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 500, ForceMode.VelocityChange);
            start = true;
            timer = 0f;
        }

        if (start)
        {
            if (timer < shootRate)
                timer += Time.deltaTime;
            else
            {
                timer = shootRate;
                start = false;
            }

        }
    }
}