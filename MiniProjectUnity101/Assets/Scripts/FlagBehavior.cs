using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagBehavior : MonoBehaviour
{
    public GameObject winpanel;
    public CharacterController chr;
    public AudioSource win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinBehavior[] coins = FindObjectsOfType<CoinBehavior>();
        if (collision.gameObject.tag == "Player")
        {
            if (coins.Length == 0)
            {
                Debug.Log("You won !");
                win.Play();
                winpanel.SetActive(true);
                chr.enabled = false;
            }
            else
                Debug.Log("There are " + coins.Length + " coins left.");
        }
    }
}
