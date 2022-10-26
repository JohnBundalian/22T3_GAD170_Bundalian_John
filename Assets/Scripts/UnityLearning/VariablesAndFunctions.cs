using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class VariablesAndFunctions : MonoBehaviour
    {
        // int meaning interger meaning whole number.
        // int myInt = declaration
        // = 5; intialisation assigmnet of information to store.
        int myInt = 55; 

        // Start is called before the first frame update
        void Start()
        {
            // Debug.Log will get the value of any variable in our game.
            // (myInt * 2); myInt variable that is multipled by a given independant variable of 2.
            Debug.Log(myInt * 2);
        }

    }
}

