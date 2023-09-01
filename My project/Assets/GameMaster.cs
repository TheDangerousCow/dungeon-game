using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMaster : MonoBehaviour
{

    public TMP_Text fishText;
    public float testValue;

    public void fishButt()
    {
        fishText.gameObject.SetActive(true);
    }
}
