using UnityEngine;
public class TargetIndicator : MonoBehaviour
{
    public Transform Target;
    public float HideDistance;
    //https://www.youtube.com/watch?v=U1SdjGUFSAI&list=PL9Fe2AaotW8AWUy7yGtIWAIPZ4b_D4ieu&index=1&t=13s

    private void Update()
    {
        var dir = Target.position - transform.position;

        if (dir.magnitude < HideDistance)
        {
            SetChildrenActive(false);
        }
        else
        {
            SetChildrenActive(true);

            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
    void SetChildrenActive(bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }
}
