using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyHealth = 10;
    [SerializeField] TextMeshProUGUI myText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            myText.text = "Enemy Health: " + enemyHealth;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            myText.text = "Enemy Health: " + enemyHealth;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Enemy Health: " + enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
