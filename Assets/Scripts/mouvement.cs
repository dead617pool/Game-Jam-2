using UnityEngine;

public class Mouvement : MonoBehaviour
{
    [SerializeField]
    private int maxMouvement;
    [SerializeField]
    private int mouvement;
    [SerializeField]
    private int minMouvement;
    [SerializeField]
    private bool canmoove;
    private void Start()
    {
        
    }
    void Update()
    {
        if (canmoove){
            canmoove = false;
            if (Input.GetKeyDown(KeyCode.UpArrow) && mouvement <= maxMouvement)
            {
                Debug.Log("test");
                transform.Translate(0, 5f, 0);
                mouvement++;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && mouvement >= -minMouvement)
            {
                transform.Translate(0, -5f, 0);
                mouvement--;
            }
            canmoove =true;
        }
    }
}
