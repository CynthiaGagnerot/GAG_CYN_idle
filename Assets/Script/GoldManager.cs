using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int star;
    public int cake;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI cakeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cake = 1;            
    }

    public void AddStar()
    {
        star += cake;
        goldText.text = $"Star : {star}";
    }

    public void AddCake()
    {
        if (star > 10)
        {
            star -= 10;
            cakeText.text = $"Cake : {cake}";

            cake += 1; 
            goldText.text = $"Star : {star}";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
