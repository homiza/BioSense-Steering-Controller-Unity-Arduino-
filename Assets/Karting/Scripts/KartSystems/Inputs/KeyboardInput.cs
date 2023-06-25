using UnityEngine;
using System.Collections;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";
        

        public override InputData GenerateInput() {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
             
                TurnInput = Input.GetAxis("Horizontal") // GetAxis is Unity defualt "A & D or Arrow L R keys". SOOOOOO..I need to write a new GetAxis or modify this
                
            };
        }

      
    }
}
