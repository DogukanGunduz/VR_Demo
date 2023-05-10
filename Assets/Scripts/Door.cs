using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Vector3 doorPosition;
    public Vector3 lowDoorPosition;
    public Vector3 highDoorPosition;

    // Start is called before the first frame update
    void Start()
    {
        doorPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, doorPosition, Time.deltaTime);
    }

    public void lowDoor()
    {
        doorPosition = lowDoorPosition;
    }

    public void highDoor()
    {
        doorPosition = highDoorPosition;
    }
}
