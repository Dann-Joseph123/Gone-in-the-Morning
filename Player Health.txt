using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    public Slider HealthSlider;
    public float MaxHP = 100f;
    public float CurrentHP;
    public GameoverScript Gameover;
    

    public void Start()
    {
        CurrentHP = MaxHP;
        HealthSlider.maxValue = MaxHP;
    }

    public void UpdateHP(float mod)
    {
        CurrentHP += mod;

        if (CurrentHP > MaxHP)
        {
            CurrentHP = MaxHP;
        }
        else if (CurrentHP <= 0f)
        {
            CurrentHP = 0f;
            if(CurrentHP == 0)
            {
                SceneManager.LoadScene("GameoverScreen"); //loads Gameover
                Destroy(gameObject);               
            }
        }
    }
    private void OnGUI()
    {
        HealthSlider.value = CurrentHP;
    }

}
