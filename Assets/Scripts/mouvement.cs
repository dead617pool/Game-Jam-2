using UnityEngine;

public class mouvement : MonoBehaviour
{
    [SerializeField]
    private int maxMouvement;
    [SerializeField]
    private int Mouvement;
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
            if (Input.GetKeyDown(KeyCode.UpArrow) && Mouvement <= maxMouvement)
            {
                Debug.Log("test");
                transform.Translate(0, 5f, 0);
                Mouvement++;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Mouvement >= -minMouvement)
            {
                transform.Translate(0, -5f, 0);
                Mouvement--;
            }
            canmoove =true;
        }
    }
}
