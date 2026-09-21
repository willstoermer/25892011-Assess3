using UnityEngine;

public class CatSpriteAnimationPreviewScript : MonoBehaviour
{
    [SerializeField] private RuntimeAnimatorController CatAnimation;
    [SerializeField] private RuntimeAnimatorController CatScaredAnimation;
    [SerializeField] private RuntimeAnimatorController CatDeadAnimation;

    private Animator animator;
    private float seconds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds * 4 > Time.time) 
        {
            if (seconds % 3 == 0) {
                animator.runtimeAnimatorController = CatDeadAnimation;
            } 
            else if (seconds % 3 == 1) 
            {
                animator.runtimeAnimatorController = CatAnimation;
            }
            else 
            {
                animator.runtimeAnimatorController = CatScaredAnimation;
            }
        }

        seconds = Mathf.Ceil(Time.time / 4);
    }
}
