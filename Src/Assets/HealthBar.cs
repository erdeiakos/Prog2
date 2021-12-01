using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image HelthBar;
    public float    CurrentHealth;
    private float MaxHealth=10f;
    CharacterController2D Player;
    
    private void Start()
    {
        //Find
        HelthBar=GetComponent<Image>();
        Player=FindObjectOfType<CharacterController2D>();
    }
    private void Update()
    {
        CurrentHealth=Player.life;
        HelthBar.fillAmount=CurrentHealth/MaxHealth;
    }
}
