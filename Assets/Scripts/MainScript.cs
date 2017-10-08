using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    strangeRoom,
    rosmarus,
    anotherDimension,
    goodEnd
}

public class MainScript : MonoBehaviour 
{
    public Text mainText;

    private States myState;

    public Image myImage;

    public Sprite[] allImages;
    
	// Use this for initialization
	void Start () 
	{
        myState = States.strangeRoom;
	}
	
	// Update is called once per frame
	void Update ()
    {
        myImage.sprite = allImages[(int) myState];

        if (myState == States.strangeRoom)
            StrangeRoom();
        if (myState == States.rosmarus)
            Rosmarus();
        if (myState == States.anotherDimension)
            AnotherDimension();
        if (myState == States.goodEnd)
            GoodEnd();
    }

    private void StrangeRoom()
    {
        mainText.text = "Вы проснулись у себя дома. " +
            "Чтоб перейти в комнату к любимому моржу, нажмите Q. " +
            "Для того, чтоб выйти из дома, нажмите W.";

        if (Input.GetKeyDown(KeyCode.Q))
            myState = States.rosmarus;
        if (Input.GetKeyDown(KeyCode.W))
            myState = States.goodEnd;
    }

    private void Rosmarus()
    {
        mainText.text = "Подойдя к двери, ведущей в комнату моржа, вы заметили, " +
            "что из замочной скважины идет странное, темное свечение. " +
            "Отойти от двери - S. Набравшись храбрости, распахнуть дверь - D.";
        if (Input.GetKeyDown(KeyCode.S))
            myState = States.strangeRoom;
        if (Input.GetKeyDown(KeyCode.D))
            myState = States.anotherDimension;
    }
    
    private void GoodEnd()
    {
        mainText.text = "К счастью для вас, здание было покинуто. " +
            "Только снаружи стало понятно, что это совсем не ваш дом, а утроба чудища.";
    }

    private void AnotherDimension()
    {
        mainText.text = "Порыв ветра втолкнул вас. Вы оказались в незнакомом вам месте. " +
            "Вас накрыло ощущение, что во всем, что вас окружало, что-то было не так. " +
            "Вы осознали, что предметы не подчинялись законам земной физики - вы оказались где угодно, " +
            "но не на Земле, и обречены вечно скитаться по темным уголкам этого недружелюбного мира!";
    }
}
