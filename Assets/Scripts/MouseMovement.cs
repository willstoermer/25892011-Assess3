using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private Tweener tweener;
    private float tweenSpeed = 0.5f;
    
    private Animator animator;
    private float x;
    private float y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tweener = GetComponent<Tweener>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     tweener.AddTween(transform, transform.position, new Vector3 (-2.0f, 0.5f, 0.0f), 1.5f);
        // }
        // else if (Input.GetKeyDown(KeyCode.D))
        // {
        //     tweener.AddTween(transform, transform.position, new Vector3 (2.0f, 0.5f, 0.0f), 1.5f);
        // }
        // else if (Input.GetKeyDown(KeyCode.S))
        // {
        //     tweener.AddTween(transform, transform.position, new Vector3 (0.0f, 0.5f, -2.0f), 0.5f);
        // }
        // else if (Input.GetKeyDown(KeyCode.W))
        // {
        //     tweener.AddTween(transform, transform.position, new Vector3 (0.0f, 0.5f, 2.0f), 0.5f);
        // }

        // CODE FROM THE WEEK 7 TWEEN CONTROLLER THAT WILL BE TURNED INTO A PROPER MOVEMENT CONTROLLER FROR AT4

        if ((Vector3.Distance(transform.position, new Vector3(-7.5f, 13.5f, 0f)) > 0.01f) && (transform.position.x == -7.5f))
        {
            tweener.AddTween(transform, transform.position, new Vector3(
                transform.position.x,
                transform.position.y + 1,
                transform.position.z), tweenSpeed);
        }
        else if ((Vector3.Distance(transform.position, new Vector3(-12.5f, 13.5f, 0f)) > 0.01f) && (transform.position.y == 13.5f))
        {
            tweener.AddTween(transform, transform.position, new Vector3(
                transform.position.x - 1,
                transform.position.y,
                transform.position.z), tweenSpeed);
        }
        else if ((Vector3.Distance(transform.position, new Vector3(-12.5f, 9.5f, 0f)) > 0.01f) && (transform.position.x == -12.5f))
        {
            tweener.AddTween(transform, transform.position, new Vector3(
                transform.position.x,
                transform.position.y - 1,
                transform.position.z), tweenSpeed);
        }
        else if ((Vector3.Distance(transform.position, new Vector3(-7.5f, 9.5f, 0f)) > 0.01f) && (transform.position.y == 9.5f))
        {
            tweener.AddTween(transform, transform.position, new Vector3(
                transform.position.x + 1,
                transform.position.y,
                transform.position.z), tweenSpeed);
        }

        animator.SetFloat("XChange", transform.position.x - x);
        animator.SetFloat("YChange", transform.position.y - y);
        x = transform.position.x;
        y = transform.position.y;
    }
}
