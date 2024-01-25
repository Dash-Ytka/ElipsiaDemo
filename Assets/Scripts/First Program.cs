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
        #region Задание 1

        // Однострочный комментарий
        int myInt = 10; // Объявление переменной типа int
        float myFloat = 20.5f; // Объявление переменной типа float
        bool myBool = true; // Объявление переменной типа bool
        string myString = "Hello, teacher!"; // Объявление переменной типа string
        /* Многострочный комментарий
           Объявление констант 
        */
        const int myConstInt = 100;
        const float myConstFloat = 200.5f;
        const bool myConstBool = false;
        const string myConstString = "My name is Daria(:";

        Debug.Log(myConstString);
        Debug.Log(myFloat);

        #endregion

        #region Задание 2

        int resultInt = myInt + myConstInt; // Сложение int
        float resultFloat = myFloat - myConstFloat; // Вычитание float
        string resultString = myString + " " + myConstString; // Конкатенация строк

        Debug.Log(resultString);

        #endregion

        #region Задание 3
       
        double sqrtResult = Math.Sqrt(myInt); // Корень квадратный
        double powResult = Math.Pow(myFloat, 2); // Возведение в степень

        Debug.Log(sqrtResult);
        Debug.Log(Math.Sqrt(9));

        #endregion

        #region Задание 4

        // Неявное преобразование
        double myDouble = myInt;
        Debug.Log(myDouble);

        // Явное преобразование
        int myNewInt = (int)myFloat;
        Debug.Log(myNewInt);

        #endregion

        #region Задание 5

        string[] myArray = new string[3] { "One", "Two", "Three" };
        Debug.Log(myArray[0]);
        Debug.Log(myArray[1]);
        Debug.Log(myArray[2]);

        #endregion

        #region Задание 6

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

        #region Задание 7     

        MyStruct myStruct;
        myStruct.X = 19;
        myStruct.Y = myInt + myConstInt;
        Debug.Log(myStruct.X);
        Debug.Log(myStruct.Y);

        #endregion

        #region Задание 8

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

        #region Задание 9

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

        #region Задание 10

        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log(myArray[i]); // Вывод элементов массива 
        }
        while (myList.Count > 0)
        {
            Debug.Log(myList[0]); // Вывод первого элемента списка 
            myList.RemoveAt(0); // Удаление первого элемента списка 
        }
        myInt = 2;
        do
        {
            Debug.Log(myInt); // Вывод значения myInt 
            myInt--; // Уменьшение значения myInt на 1 
        } while (myInt > 0);

        #endregion

        #region Задание 11

        void MyFunction()
        {
            Debug.Log("This is my function!(:<"); // Вывод сообщения 
        }
        MyFunction(); // Вызов функции

        #endregion

        #region Задание 12

        void MyFunctionWithParameters(int param1, string param2)
        {
            Debug.Log("This is my function with parameters: " + param1 + ", " + param2); // Вывод сообщения с параметрами 
        }
        MyFunctionWithParameters(myInt, myString); // Вызов функции с параметрами

        #endregion

        #region Задание 13
        int MyFunctionWithReturnValueAndParameters(int param1, int param2)
        {
            return param1 + param2; // Возврат суммы параметров 
        }
        int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt); // Вызов функции с параметрами и сохранение результата 
        Debug.Log(result); // Вывод результата

        #endregion
    }
}
