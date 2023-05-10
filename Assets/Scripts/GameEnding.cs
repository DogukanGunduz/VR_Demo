using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public Collectible collectible;
    public Text gameEnding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collectible.puan == 5)
        {
            gameEnding.text = "Oyun Bitti. Çıkmak için ESC tuşuna basabilirsin.";
        }
    }
}
