using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RowController : MonoBehaviour
{
    public float totalValue = 0;                           // La valeur totale associée à cette personne, initialisée à 0
    public TextMeshProUGUI total;                           // L'objet text total associé à cette personne
    public TMP_InputField field;                            // L'objet InputField associé à cette personne
    public TotalNotSharedController notSharedController;

    public void AddValue()
    {
        if(field.text != "")
        {
            float value = float.Parse(field.text);
            totalValue += value;
            field.text = "";
            total.text = "" + totalValue;
            notSharedController.Add(value);
        }
    }
}
