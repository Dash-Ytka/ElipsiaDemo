using System;
using System.Collections.Generic;
using UnityEngine;

public class FirstProgram : MonoBehaviour
{

    struct MyStruct
    {
        public int X;
        public int Y;
    }

    void Start()
    {
        #region ������� 1

        // ������������ �����������
        int myInt = 10; // ���������� ���������� ���� int
        float myFloat = 20.5f; // ���������� ���������� ���� float
        bool myBool = true; // ���������� ���������� ���� bool
        string myString = "Hello, teacher!"; // ���������� ���������� ���� string
        /* ������������� �����������
           ���������� �������� 
        */
        const int myConstInt = 100;
        const float myConstFloat = 200.5f;
        const bool myConstBool = false;
        const string myConstString = "My name is Daria(:";

        Debug.Log(myConstString);
        Debug.Log(myFloat);

        #endregion

        #region ������� 2

        int resultInt = myInt + myConstInt; // �������� int
        float resultFloat = myFloat - myConstFloat; // ��������� float
        string resultString = myString + " " + myConstString; // ������������ �����

        Debug.Log(resultString);

        #endregion

        #region ������� 3
       
        double sqrtResult = Math.Sqrt(myInt); // ������ ����������
        double powResult = Math.Pow(myFloat, 2); // ���������� � �������

        Debug.Log(sqrtResult);
        Debug.Log(Math.Sqrt(9));

        #endregion

        #region ������� 4

        // ������� ��������������
        double myDouble = myInt;
        Debug.Log(myDouble);

        // ����� ��������������
        int myNewInt = (int)myFloat;
        Debug.Log(myNewInt);

        #endregion

        #region ������� 5

        string[] myArray = new string[3] { "One", "Two", "Three" };
        Debug.Log(myArray[0]);
        Debug.Log(myArray[1]);
        Debug.Log(myArray[2]);

        #endregion

        #region ������� 6

        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        myList.Remove(2);
        myList.RemoveAt(0);
        Debug.Log(myList[0]);

        #endregion

        #region ������� 7     

        MyStruct myStruct;
        myStruct.X = 19;
        myStruct.Y = myInt + myConstInt;
        Debug.Log(myStruct.X);
        Debug.Log(myStruct.Y);

        #endregion

        #region ������� 8

        bool condition = true;

        if (myInt > 0 && condition)
        {
            Debug.Log("myInt pologitelen.");
        }
        else
        {
            Debug.Log("myInt is otritsatelen.");
        }

        #endregion

        #region ������� 9

        switch (myString)
        {
            case "Hello, teacher!":
                Debug.Log("Glad to meet you.");
                break;
            case "My name is Daria(:":
                Debug.Log("What about you?");
                break;
            default:
                Debug.Log("See you");
                break;
        }

        #endregion

        #region ������� 10

        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log(myArray[i]); // ����� ��������� ������� 
        }
        while (myList.Count > 0)
        {
            Debug.Log(myList[0]); // ����� ������� �������� ������ 
            myList.RemoveAt(0); // �������� ������� �������� ������ 
        }
        myInt = 2;
        do
        {
            Debug.Log(myInt); // ����� �������� myInt 
            myInt--; // ���������� �������� myInt �� 1 
        } while (myInt > 0);

        #endregion

        #region ������� 11

        void MyFunction()
        {
            Debug.Log("This is my function!(:<"); // ����� ��������� 
        }
        MyFunction(); // ����� �������

        #endregion

        #region ������� 12

        void MyFunctionWithParameters(int param1, string param2)
        {
            Debug.Log("This is my function with parameters: " + param1 + ", " + param2); // ����� ��������� � ����������� 
        }
        MyFunctionWithParameters(myInt, myString); // ����� ������� � �����������

        #endregion

        #region ������� 13
        int MyFunctionWithReturnValueAndParameters(int param1, int param2)
        {
            return param1 + param2; // ������� ����� ���������� 
        }
        int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt); // ����� ������� � ����������� � ���������� ���������� 
        Debug.Log(result); // ����� ����������

        #endregion
    }
}
