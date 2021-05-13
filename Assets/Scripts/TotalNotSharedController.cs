using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalNotSharedController : MonoBehaviour
{
    public float totalNotShared = 0;

    public void Add(float value)
    {
        totalNotShared += value;
        gameObject.GetComponent<TextMeshProUGUI>().text = "" + totalNotShared;
    }
}
