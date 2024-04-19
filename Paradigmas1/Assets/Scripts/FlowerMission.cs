using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMission : MonoBehaviour
{
    public GameObject flower;
    public int flowercount;
    public MissionSystem ms;
    // Start is called before the first frame update
    void Start()
    {
        ms.mission.text = "Collect 3 Flowers. Reward: 3 Gold";
    }

    // Update is called once per frame
    void Update()
    {
        if (flowercount >= 3)
        {
            ms.CompleteMission();
        }
    }
    public void InstanceFlowers()
    {
        Instantiate(flower, new Vector3(3, 3, 0), flower.transform.rotation);
        Instantiate(flower, new Vector3(-7, -3, 0), flower.transform.rotation);
        Instantiate(flower, new Vector3(8, 2, 0), flower.transform.rotation);
    }
    public void MissionCancelled()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Flower");

        // Loop through each object and destroy it
        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }
}
