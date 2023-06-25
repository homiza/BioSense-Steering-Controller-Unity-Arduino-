using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlParticle : MonoBehaviour
{
    // Listen to change in thrust
    // adjust Particle values

    [SerializeField]
    private ParticleSystem sys;

    [SerializeField]
    private float minStartSpeed, maxStartSpeed;

    //Create a subsystem which includes the ones you modify (emission etc) in particlesystem 
    private ParticleSystem.MainModule sysMain;

    
    private void OnEnable()
    {
        sysMain = sys.main;
    }

    
    private void SetStartSpeed(float thrustInPercent)
    {
        float speed = thrustInPercent * maxStartSpeed + (1f - thrustInPercent) * minStartSpeed;

        sysMain.startSpeed = speed;
    }
}
