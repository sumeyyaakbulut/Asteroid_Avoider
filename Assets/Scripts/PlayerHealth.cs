using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverHandler gameOverHandler;
    public AudioClip crash;
    public void Crash()
    {
        gameOverHandler.EndGame();
        gameObject.SetActive(false);
    }

   /* public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("obstacle");
            GetComponent<AudioSource>().PlayOneShot(crash, 1f);
        }
    }*/
}
