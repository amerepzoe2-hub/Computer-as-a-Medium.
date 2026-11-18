using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    
  
    public float speed = 10f;
    public float destroyTime = 3f;
    public Rigidbody2D rb;
    public Enemy enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
       
    }
   
}
