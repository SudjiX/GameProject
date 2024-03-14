using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public float movementSpeed;
    Transform Player;

    public int health;

    void Start()
    {
        Player = FindObjectOfType<Player_Control>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, movementSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            TakeDamage(other.GetComponent<Projectile>().damage);
        }

        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Game");
        }
    }

    void TakeDamage(int dammageAmount)
    {
        health -= dammageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}