using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour{

public string anyString
{
	get 
	{
	return anyString;
	}

	set 
	{
	anyString = value;
	}
}

public void helloPrint(string thisString)
{

Debug.Log("This is the requested: " + thisString);

}

}
