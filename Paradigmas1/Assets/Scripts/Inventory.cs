using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI inventory;
    public TextMeshProUGUI inventoryAmount;
    public List<string> items;
    public List<int> itemsAmount;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        StringBuilder stringBuilder = new StringBuilder();
        StringBuilder stringBuilder2 = new StringBuilder();

        for (int i = 0; i < items.Count; i++)
        {
            stringBuilder.AppendLine(items[i]);
            stringBuilder2.AppendLine(itemsAmount[i].ToString()); // Append amount
        }

        inventory.text = stringBuilder.ToString();
        inventoryAmount.text = stringBuilder2.ToString();
    }

    public void AddItem(string names)
    {
        UpdateText();

        int index = items.IndexOf(names);
        if (index == -1)
        {
            items.Add(names);
            itemsAmount.Add(1); 
        }
        else
        {
            itemsAmount[index]++; 
        }
    }
    public void RemoveItem(int IndexNumber)
    {
        UpdateText();

        if (itemsAmount[IndexNumber] >= 2)
        {
            itemsAmount[IndexNumber]--;
        }
        else if (itemsAmount[IndexNumber] == 1)
        {
            itemsAmount.RemoveAt(IndexNumber);
            items.RemoveAt(IndexNumber);
        }
    }
}
