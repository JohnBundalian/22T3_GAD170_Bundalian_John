using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class MultiplyByTwo : MonoBehaviour
    {
        // int meaning interger meaning whole number.
        // int myInt = declaration
        // = 5; intialisation assigmnet of information to store.
        [SerializeField] private int myInt = 5;
        private string message = "Multiply By Two Result";

        // Start is called before the first frame update
        void Start()
        {
            myInt = MultipleByTwo(myInt);
            Debug.Log(message);
            Debug.Log(myInt);
        }

        int MultipleByTwo(int number)
        {
            int result;
            result = number * 2;
            return result;
        }
    }
}