using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class ContactDirectory1 : MonoBehaviour
    {
        // Contact is another method of displaying lots of information.
        // "<Contact>" are responsible for the gameObjects that contain the "Contact" scrip to be accepted.
        // Note that both <Contact> first and last must be identical for changes to be accepted.
        [SerializeField] private List<Contact> contacts = new List<Contact>();

        private void Start()
        {

            // Loops through collection.
            // Creates integer call I and give it value of 0
            // if i < Count, then do things inside this loop.
            // Then, increase i by 1... masking i = 1.. then i =2... then i =3...

            for(int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialise();
            }
        }
    }
}

