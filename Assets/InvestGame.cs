using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InvestGame : MonoBehaviour
{
    public Text BalanceText;
    public Text JobTitleText;
    public Text HourlyIncomeText;
    public double balance;

    public void Start()
    {

    }

    public void Update()
    {
        BalanceText.text = "$" + balance;
    }

    // Buttons
    public void EarnClick()
    {
        balance += Random.Range(0f, 1);
        balance = System.Math.Round(balance, 2);
    }

    // Jobs (they are now just buttons for testing purposes)
    public void SwitchToJob1Click()
    {
        JobTitleText.text = "unemployed";
    }

    public void SwitchToJob2Click()
    {
        JobTitleText.text = "cashier";
    }
}