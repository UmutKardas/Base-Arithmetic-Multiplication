using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class EntryController : MonoBehaviour
{

    [SerializeField] private InputField firstNumberInput;
    [SerializeField] private InputField secondNumberInput;
    [SerializeField] private InputField baseNumberInput;
    [SerializeField] private GameObject enter;
    [SerializeField] private GameObject restart;
    [SerializeField] private Text resultNumberText;


    public List<Text> resultText = new List<Text>();
    public List<long> residualList = new List<long>();


    private string firstNumber;
    private string secondNumber;
    private int baseNumber;


    private long firtNumberToBase10 = 0;
    private long secondNumberToBase10 = 0;
    private long multiplication;


    private int firstNumberLength;
    private int secondNumberLength;



    public void SetEntryEnterButton()
    {
        SetInputNumber();
        SetActiveResult();
        SetNumberLenght();
        SetConvertToBase10(0, 0, null);
        SetConvertToBaseSelect();
    }



    private void SetInputNumber()
    {
        firstNumber = firstNumberInput.text;
        secondNumber = secondNumberInput.text;
        baseNumber = Convert.ToInt32(baseNumberInput.text);
    }



    private void SetNumberLenght()
    {
        firstNumberLength = firstNumber.Length;
        secondNumberLength = secondNumber.Length;
    }



    private void SetConvertToBase10(int digitNumber, float overcount, string digitNumberString)
    {
        for (int i = 0; i <= firstNumberLength + 2; i++)
        {
            if (firstNumberLength > 0)
            {
                digitNumberString = firstNumber.Substring(i, 1);
                firstNumberLength--;
            }


            if (digitNumberString.ToUpper() == "A")
            {
                digitNumber = 10;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "B")
            {
                digitNumber = 11;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "C")
            {
                digitNumber = 12;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "D")
            {
                digitNumber = 13;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "E")
            {
                digitNumber = 14;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "F")
            {
                digitNumber = 15;
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }

            else
            {
                digitNumber = Convert.ToInt32(digitNumberString);
                overcount = Mathf.Pow(baseNumber, firstNumberLength);
                firtNumberToBase10 += (int)overcount * digitNumber;
            }
        }



        for (int i = 0; i <= secondNumberLength + 2; i++)
        {
            if (secondNumberLength > 0)
            {
                digitNumberString = secondNumber.Substring(i, 1);
                secondNumberLength--;
            }


            if (digitNumberString.ToUpper() == "A")
            {
                digitNumber = 10;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "B")
            {
                digitNumber = 11;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "C")
            {
                digitNumber = 12;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "D")
            {
                digitNumber = 13;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "E")
            {
                digitNumber = 14;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else if (digitNumberString.ToUpper() == "F")
            {
                digitNumber = 15;
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }

            else
            {
                digitNumber = Convert.ToInt32(digitNumberString);
                overcount = Mathf.Pow(baseNumber, secondNumberLength);
                secondNumberToBase10 += (int)overcount * digitNumber;
            }
        }
        multiplication = firtNumberToBase10 * secondNumberToBase10;
    }



    private void SetConvertToBaseSelect()
    {
        for (int i = 0; i < multiplication; i++)
        {
            if (multiplication > 0)
            {
                if (multiplication > baseNumber)
                {
                    long residual = multiplication % baseNumber;
                    Debug.Log("kalan" + residual);
                    multiplication = multiplication / baseNumber;
                    residualList.Add(residual);

                    if (multiplication <= baseNumber)
                    {
                        Debug.Log("bolum" + multiplication);
                        residualList.Add(multiplication);
                        residualList.Reverse();

                        foreach (var item in residualList)
                        {
                            item.ToString();
                            resultNumberText.text += item + ",";
                        }
                    }
                }
            }
        }
    }

    public void SetRestartButton()
    {
        SceneManager.LoadScene(0);
    }



    private void SetActiveResult()
    {
        foreach (var text in resultText)
        {
            text.gameObject.SetActive(true);
            enter.SetActive(false);
            restart.SetActive(true);
        }
    }
}
