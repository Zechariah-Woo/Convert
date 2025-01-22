using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Conversionofunits : MonoBehaviour
{   

    //currency variables
    public float PHP;
    public float Dollars;
    public float Won;
    public float Yen;
    public float BTC;
    public float Euros;
    public float Rupees; 

    //UI variables
    public TMP_InputField inputField;
    public TextMeshProUGUI convertedValue;

    //function that converts dollars

    public void ToDollarrs()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * Dollars;
            convertedValue.text  = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }  public void ToBTC()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * BTC;
            convertedValue.text  = "BTC" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }public void ToYen()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * Yen;
            convertedValue.text  = "¥" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }public void ToWon()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * Won;
            convertedValue.text  = "₩" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }
public void ToEuros()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * Euros;
            convertedValue.text  = "€" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }public void ToRupee()
    {
        string InputValue = inputField.text;
        float numericValue;
        if ((float.TryParse(InputValue, out numericValue)))
        {
           // Debug.Log(numericValue);
           PHP = numericValue * Rupees;
            convertedValue.text  = "₹" + PHP.ToString();
        }
        else
        {
            Debug.Log("Invalid Input");
        }
    }


}
