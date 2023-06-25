using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SensorValuesReader : MonoBehaviour
{
    // Start is called before the first frame update
    public int fValue;
    public SerialController serialController;

    public TMP_Text PressureValue;
    public TMP_Text SteeringValue;

    public TMP_Text PulseValue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //   forceTxt.text = fValue.ToString();    
    }

    public void forceValue(){
       fValue++;
    
    }
     void OnMessageArrived(string msg)
    {
         Debug.Log("Arrived: " + msg);
         //forceTxt.text = msg;
         //forceTxt2.text = msg;
         

         string[] elements = msg.Split(' ');
          //  int x = int.Parse(elements[0]);
           
            PressureValue.text = elements[0];
            SteeringValue.text = elements[1];
            PulseValue.text = elements[2];
            //float z = float.Parse(elements[2]);
         int x = 0;
         int.TryParse(PressureValue.text, out x);
         
         if( x >= 150){
            SteeringValue.color = Color.red;
         }
         else{
            SteeringValue.color = Color.white;
         }



    }
    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
