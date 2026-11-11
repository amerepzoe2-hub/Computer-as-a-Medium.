using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject objectToShow;
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            objectToShow.SetActive(true);
        }

    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToShow.SetActive(false);
        }
    }
}
