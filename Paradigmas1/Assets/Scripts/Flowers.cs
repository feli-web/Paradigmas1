using NUnit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
    FlowerMission fm;
    void Start()
    {
        GameObject playerMovementObject = GameObject.Find("Flower Mission");

        // Get the PlayerMovement component from the GameObject
        fm = playerMovementObject.GetComponent<FlowerMission>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        fm.flowercount++;
        StartCoroutine(Dissappear());
    }
    public IEnumerator Dissappear()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.grey;
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}
