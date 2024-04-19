using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemValues : MonoBehaviour
{
    Inventory inv;
    public string names;

    void Start()
    {
        GameObject playerMovementObject = GameObject.Find("Inventory");

        // Get the PlayerMovement component from the GameObject
        inv = playerMovementObject.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        inv.AddItem(names);
        StartCoroutine(Dissappear());
    }
    public IEnumerator Dissappear()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.grey;
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}
