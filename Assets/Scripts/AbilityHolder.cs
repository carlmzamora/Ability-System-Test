using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    [SerializeField] private Ability ability;
    [SerializeField] private KeyCode key;

    enum AbilityState
    {
        READY,
        ACTIVE,
        COOLDOWN
    }

    float currentCDTime;
    float currentActiveTime;

    private AbilityState state = AbilityState.READY;

    private void Update()
    {
        switch(state)
        {
            case AbilityState.READY:
                if (Input.GetKeyDown(key))
                {
                    ability.Activate();
                    state = AbilityState.ACTIVE;
                    currentActiveTime = ability.activeTime;
                }
            break;
            case AbilityState.ACTIVE:
                if(currentActiveTime > 0)
                {
                    currentActiveTime -= Time.deltaTime;
                }
                else
                {
                    state = AbilityState.COOLDOWN;
                    currentCDTime = ability.cdTime;
                }
            break;
            case AbilityState.COOLDOWN:
                if (currentCDTime > 0)
                {
                    currentCDTime -= Time.deltaTime;
                }
                else
                {
                    state = AbilityState.READY;
                }
                break;
        }
        
    }
}
