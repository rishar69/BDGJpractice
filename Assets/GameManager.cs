using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private float minCountdown = 0f; 
    private float maxCountdown = 10f; 
    private float countdown = 10f;
    private bool inDarkness = true;
    public RectTransform hpBar;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
    }

    private void Update()
    {
        Vector3 currentScale = hpBar.localScale;
        hpBar.localScale = new Vector3(currentScale.z, currentScale.y, countdown);  

        if (inDarkness)
        {
            CountDown();
            if(countdown == 0f)
            {
                Debug.Log($"You Are Dead");
            }
        }
        else
        {
            CountUp();
        }
    }

    public void CountDown()
    {
        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, minCountdown, maxCountdown);
        Debug.Log($"{countdown}");

    }

    public void CountUp()
    {
        countdown += Time.deltaTime*2;
        countdown = Mathf.Clamp(countdown, minCountdown, maxCountdown);
        Debug.Log($"{countdown}");
    }

    public void IndarknessState(bool State)
    {
        inDarkness = State;
    }

}

