using UnityEngine;

public class Movable : MonoBehaviour
{
    private float Speed { get; set; }
    private float TargetX { get; set; }

    private void Awake()
    {
        Speed = Random.Range(0.5f, 1.25f);
        TargetX = Random.Range(-1.73f, 1.73f);
    }

    private void Update()
    {
        if(!Level.IsReady)
        {
            return;
        }

        transform.localPosition = Vector2.MoveTowards(transform.position, new Vector2(TargetX, transform.localPosition.y), Speed * Time.deltaTime);
        if(Vector2.Distance(transform.localPosition, new Vector2(TargetX, transform.localPosition.y)) < 0.25f)
        {
            if(IsInvoking(nameof(SetTarget)))
            {
                return;
            }

            Invoke(nameof(SetTarget), Random.Range(1.0f, 2.0f));
        }
    }

    private void SetTarget()
    {
        TargetX = Random.Range(-1.73f, 1.73f);
    }
}
