using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculatePrice : MonoBehaviour
{
    public TotalNotSharedController notSharedController;
    public RowController rowController1;
    public RowController rowController2;
    public RowController rowController3;
    public RowController rowController4;
    public TMP_InputField globalPriceField;

    public void Calculate()
    {
        if (globalPriceField.text != "")
        {
            float value = float.Parse(globalPriceField.text);
            value -= notSharedController.totalNotShared;

            rowController1.total.text = "" + (rowController1.totalValue + value / 4);
            rowController2.total.text = "" + (rowController2.totalValue + value / 4);
            rowController3.total.text = "" + (rowController3.totalValue + value / 4);
            rowController4.total.text = "" + (rowController4.totalValue + value / 4);
        }
    }
}
