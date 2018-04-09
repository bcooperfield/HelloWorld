using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameObject : HelloWorld {

string betterString;

HelloWorld helloWorld = new HelloWorld();

void Start()
{
helloWorld.anyString = "This is wonderful!";
Debug.Log("aaa " + anyString);
//betterString = helloWorld.anyString;
//helloWorld.helloPrint(betterString);
}

}
