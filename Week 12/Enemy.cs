using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject deathBubble;
    private bool isDead = false;

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Bullet") && !isDead)

        {

            enemyHealth -= 10;
            Destroy(other.gameObject);

            if (enemyHealth <= 0)

            {

                StartCoroutine(Death());

            }

        }

    }

    IEnumerator Death()

    {

        isDead = true;

        deathBubble.SetActive(true);


        yield return new WaitForSeconds(2f);
        Destroy(gameObject);

    }

}



