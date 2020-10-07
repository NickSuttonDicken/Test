﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    //public Image fillImage;
    private int maxHealth = 100;
    private int minHealth = 0;
    private int currentHealth;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        GetSlider();
        SetMaxHealthBar();
        Debug.Log("bar");
    }

    void GetSlider()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMaxHealthBar()
    {
        if (!slider)
        {
            GetSlider();
        }
        slider.maxValue = maxHealth;
        slider.minValue = minHealth;
        slider.value = currentHealth;
    }

    public void SetMaxHealth(int health)
    {
        maxHealth = health;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        slider.value = currentHealth;
    }
}