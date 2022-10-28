using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanyCausations : MonoBehaviour
{

    [Header("Company Numebers")]
    public int timesSold;
    public int salesPrice;
    public int salesAmount;

    [Header("Numbers to change over time")]
    public int rentPrice;
    public int rentIncrease;
    public float blightChance;
    public float blightChanceMulti;


    public void SoldTo()
    {

        timesSold++;

    }

}
