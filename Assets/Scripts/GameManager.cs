using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    [SerializeField] private GameObject GaOb;
    [SerializeField] private GameObject GaOb2;
    [SerializeField] private Vector2 startPos;
    [SerializeField] private Vector2 direction;
    [SerializeField] private bool directionChosen;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){

        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            GaOb.transform.position = touch.position;
            switch (touch.phase){
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    break;

                case TouchPhase.Ended:
                    directionChosen = true;
                    break;

            }
            if (directionChosen){
                if (GaOb.transform.position == GaOb2.transform.position){
                    print("bimbimbambam");
                }
            }
        }
    }
}