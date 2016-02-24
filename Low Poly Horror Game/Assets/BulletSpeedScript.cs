using UnityEngine;
using System.Collections;

public class BulletSpeedScript : MonoBehaviour {

    public Vector3 movementVector;  //unit vector 

    public float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 3);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + movementVector * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider) {
        Debug.Log("Hit something!");
        if (collider.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit an enemy!");
            collider.gameObject.GetComponent<EnemyStats>().takeDamage(2f);
        }
    }

}
