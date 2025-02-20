using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    
    public TMP_Text healthText;
    public Slider healthSlider;

    void Start()
    {
        CurrentHealth = MaxHealth;
        healthSlider.maxValue = MaxHealth;
    }

    void Update()
    {
        healthText.text = CurrentHealth.ToString();
        healthSlider.value = CurrentHealth;
    }
}