using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int puan = 0;
    public Text puanSayisi;
    public int coinSayisi;

    // Update is called once per frame
    void Update()
    {

    }

    public async void CollectingAsync()
    {
        await Task.Delay(1000);
        puan++;
        puanSayisi.text = "Puan: " + puan;
    }

    public void CollectCoin()
    {
        coinSayisi++;
        Destroy(gameObject);
    }
}
