using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class DestroyCollectible : MonoBehaviour
{
    public Collectible collectible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public async void Destroyed()
    {
        ChangeColor();
        collectible.CollectingAsync();
        await Task.Delay(1000);
        Destroy(gameObject);
    }
}
