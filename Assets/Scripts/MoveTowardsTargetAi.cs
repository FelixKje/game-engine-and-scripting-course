using System;
using UnityEngine;

public class MoveTowardsTargetAi : MonoBehaviour{
    [SerializeField]CommandContainer commandContainer;

    [SerializeField]Transform targetTransform;

    void Start(){
        //Different ways of target detection
        //targetTransform = GameObject.FindWithTag("Player").transform; //Uses the player tag
        //targetTransform = GameObject.Find("Player").transform; //Looks for GameObject by name
        //targetTransform = ((PlayerIdentifierComponent)FindObjectOfType(typeof(PlayerIdentifierComponent))).transform; //Looks for a component of type PlayerIdentifierComponent
        //targetTransform = FindObjectOfType<PlayerIdentifierComponent>().transform; //Looks for a component of type PlayerIdentifierComponent. This time using generics.
    }

    void Update(){
        var directionToTarget = (targetTransform.position - this.transform.position).normalized;
        var horizontalDirectionToTarget = directionToTarget.x;

        commandContainer.WalkCommand = horizontalDirectionToTarget;
    }
}
