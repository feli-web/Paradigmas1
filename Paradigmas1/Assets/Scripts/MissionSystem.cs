using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MissionSystem : MonoBehaviour
{
    public TextMeshProUGUI mission;
    public TextMeshProUGUI gold;
    public Image missionPanel;
    public Image congratsPanel;
    public FlowerMission fm;
    public Button accept;
    public Button cancel;
    void Start()
    {
        missionPanel.gameObject.SetActive(false);
        congratsPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gold.text = "Gold: 0";
    }
    public void AcceptMission()
    {
        fm.InstanceFlowers();
    }
    public void CompleteMission()
    {
        mission.enabled = false;
        congratsPanel.gameObject.SetActive(true);
        accept.gameObject.SetActive(false);
        cancel.gameObject.SetActive(false);
        gold.text = "Gold: 3";

    }
    public void RejectMission()
    {
        fm.MissionCancelled();
    }
    public void MissionOpen(GameObject toOpen)
    {
        toOpen.gameObject.SetActive(true);
    }
    public void Close( GameObject toClose)
    {
        toClose.gameObject.SetActive(false);
    }
}
