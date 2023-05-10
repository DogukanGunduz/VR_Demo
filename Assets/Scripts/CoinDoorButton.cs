using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDoorButton : MonoBehaviour
{
    public Collectible collectible;
    public Door door;
    public Text doorOpened;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCoinDoor()
    {
        if (collectible.coinSayisi == 1)
        {
            door.lowDoor();
            doorOpened.text = "Tebrikler bölüm bitti. İlerdeki odadan son puanı toplayabilirsin";
        }

        else
        {
            doorOpened.text = "Açmak için para bulman lazım";
        }
    }
}
