using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyUi : MonoBehaviour
{

    public TextMeshProUGUI moneyText;
    // Update is called once per frame
    void Update()
    {
        moneyText.SetText("$" + PlayerStats.Money.ToString());
    }
}
