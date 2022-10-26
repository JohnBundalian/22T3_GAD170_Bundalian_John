using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class TemperatureChecker : MonoBehaviour
    {
        [SerializeField] private float currentPorridgeTemperature = 85.0f;

        private float hotLimitTemperature = 70.0f;
        private float coldLimitTemperature = 40.0f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TemperatureTest();
            }

            currentPorridgeTemperature -= Time.deltaTime * 5f;
        }

        private void TemperatureTest()
        {
            // if statement syntax:

            // if(CONDITION)
            // {
            // CODE HERE WILL RUN IF CONDITION IS TRUE
            // }

            if (currentPorridgeTemperature > hotLimitTemperature)
            {
                Debug.Log("The porridge is too hot!" + (int)currentPorridgeTemperature);
            }
            else if (currentPorridgeTemperature < coldLimitTemperature)
            {
                Debug.Log("The porridge is too cold!");
            }
            else
            {
                Debug.Log("The porridge is just right");
            }
        }

    }
}
