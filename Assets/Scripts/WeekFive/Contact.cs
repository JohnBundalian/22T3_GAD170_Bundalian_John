using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{ 

    // enum allows drop down menu for multiple user interface.
    // when using Enum use undefined always to allow the generic settings to be defined.
    // Using enum below name space allows it to be incoporated through out your namespace.
    public enum User { Undefined, Smitty, Dorra, Boots }

    public class Contact : MonoBehaviour
    {
        // Links to enum function where multi User input is displayed.
        // "User.Undefined is the cross reference factor."
        [SerializeField] private User chosenUser = User.Undefined;
        // This allows input of the data of the user input.
        [SerializeField] private new string name;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;
        [SerializeField] private string preferedName;

        public void Initialise()
        {
            // setting up all three characters here with a if statement "if" what?
            // using if statements
            // if variable == 0, set up Smitty. <- Example.
            // if variable == 1, set up Dorra.
            // if variable == 2, Set up boots.
            // options are:
            // if statements or switch statment.

            // switch option input the enum name as shown will input following data.
            switch (chosenUser)
            {
                case User.Undefined:
                    Debug.Log("Person is undefined. Set its enum in the inspector!");
                    break;
                case User.Smitty:
                    // This input links to string void setup input below.
                    Setup("Smitty",
                          "0412 345 678",
                           "21 Jump Street",
                           "yahoo@gmail.com",
                           "Smit");
                    // break ends the switch and goes onto the next following category.
                    break;
                case User.Dorra:
                    Setup("Dora",
                          "0434 345 678",
                           "22 Jump Street",
                           "hotmail@gmail.com",
                           "DD");
                    break;
                case User.Boots:
                    Setup("Boots",
                          "0467 345 678",
                           "23 Jump Street",
                           "bing@gmail.com",
                           "Bo");
                    break;
                    // default if any input is broken it will catch it to indicate the area is broken.
                default:
                    Debug.Log("Invalid Choice!");
                    break;
            }
                                  
        }

        // When engaging in more than one user to input data you link variables through string.
        private void Setup(string newName,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail,
                           string newPreferedName)
        {
            name = newName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
            preferedName = newPreferedName;

        }

    }
}

