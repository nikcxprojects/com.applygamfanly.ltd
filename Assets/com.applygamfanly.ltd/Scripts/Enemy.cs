using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const float offsetX = 1.5f;
    private const float speed = 1.2f;


    private const float waitTime = 4.0f;

    private SpriteRenderer Render { get; set; }

    private Vector2 target;

    private void Awake()
    {
        target = new Vector2(0, transform.position.y);
        Render = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(GameManager.IsPaused)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0) && Render.enabled)
        {
            Render.enabled = false;

            Rigidbody2D ball = Instantiate(Resources.Load<Rigidbody2D>("ball"), transform.parent);
            ball.transform.localPosition = transform.localPosition;

            Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            ball.AddForce(direction.normalized * 20, ForceMode2D.Impulse);

            Destroy(ball.gameObject, waitTime);
            Invoke(nameof(EnableRender), waitTime);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void EnableRender()
    {
        Render.enabled = true;
    }
}
