using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collectables : MonoBehaviour
{
    [SerializeField] int coinCount = 0;
    [SerializeField] TextMeshProUGUI myText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCount++;
            Destroy(collision.gameObject);
            myText.text = "Coins:" + coinCount;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
