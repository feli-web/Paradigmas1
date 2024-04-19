using TMPro;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int points;
    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI pointText;
    bool canTouch = true;
    void Start()
    {
        InvokeRepeating("ButtonChange",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + points.ToString("D2");
    }
    void AddPoints(int addedPoints)
    {
        points += addedPoints;
        if (points < 0)
        {
            points = 0;
        }if (points > 99)
        {
            points = 99;
        }
       pointText.text = "Points: "+points.ToString("D2");
    }  
    public void ButtonTouch()
    {
        if (canTouch)
        {
            AddPoints(1);
        }
        if (!canTouch)
        {
            AddPoints(-5);
        }
    }
    
    void ButtonChange()
    {
        canTouch = !canTouch;
        if (canTouch)
        {
            button.image.color = Color.green;
            buttonText.text = "Touch!!";
        }
        if (!canTouch)
        {
            button.image.color = Color.red;
            buttonText.text = "Don't Touch!!";
        }
    }
}
