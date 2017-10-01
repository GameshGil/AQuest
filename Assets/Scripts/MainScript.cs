using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    startRoom,
    washer,
    pentagon
}

public class MainScript : MonoBehaviour 
{
    public Text mainText;

    private States myState;

	void Start () 
	{
        myState = States.startRoom;
	}
	
	void Update () 
	{
        if (myState == States.startRoom)
            StartRoomFunc();

        if (myState == States.washer)
            WasherFunc();

        if (myState == States.pentagon)
            PentagonFunc();
	}

    private void StartRoomFunc()
    {
        mainText.text = "Первая сцена - вы проснулись. \nПодойти к умывальнику - Q.\nПопытаться взломать Пентагон - E";

        if (Input.GetKeyDown(KeyCode.Q))
            myState = States.washer;

        if (Input.GetKeyDown(KeyCode.E))
            myState = States.pentagon;
    }

    private void WasherFunc()
    {
        mainText.text = "Вы у умывальника. Вместо вашего лица в отражении на вас глядит кот.";
    }

    private void PentagonFunc()
    {
        mainText.text = "Вы попытались взломать пентагон. Неудачно, что было ожидаемо. Однако за такое отправили по вашему адресу ракету. Жизнь окончена.";
    }
}
