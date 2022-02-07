using System.Collections;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour{
    [SerializeField] float animationDuration = 1f;
    [SerializeField] AnimationCurve scaleAnimationCurve = AnimationCurve.Linear(0,0,1,1);
    
    public void PlayAnimation(float scaleValue){
        StartCoroutine(AnimationCoroutine(scaleValue));
    }

    IEnumerator AnimationCoroutine(float value){
        var progress = 0f;

        while (progress < 1){
            progress += Time.deltaTime / animationDuration;

            var scaleValue = scaleAnimationCurve.Evaluate(progress) * value;
            
            transform.localScale = new Vector3(1 + scaleValue, 1, 1 + scaleValue);

            yield return null;
        }
        
        transform.localScale = Vector3.one; //Safety to make sure scale gets reset properly
    }
}
