using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxhealth = 92;
    public int currenthealth;
    public healthbar healthbar;

    void Start()
    {
        currenthealth = maxhealth;
        healthbar.setmaxhealth(maxhealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takedamage(20);
        }
        if (currenthealth < 0)
        {
            Debug.Log("dead");
            currenthealth = 0;
            healthbar.sethealth(currenthealth);
        }
    }

    void takedamage(int damage)
    {
        currenthealth -= damage;
        Debug.Log("damage taken");
        healthbar.sethealth(currenthealth);
    }
}
