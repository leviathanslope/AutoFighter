using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_scr : MonoBehaviour
{
    Canvas _canvas;
    float _posX;
    float _posY;
    float _cost;

    void Start()
    {
        _cost = 3;
        _canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)_canvas.transform, pointerData.position, _canvas.worldCamera, out pos);

        transform.position = _canvas.transform.TransformPoint(pos);
    }

    void Update()
    {
        _posX = gameObject.GetComponent<RectTransform>().localPosition.x;
        _posY = gameObject.GetComponent<RectTransform>().localPosition.y;

        _boardPosSetup();
        _mouseUp();
    }

    void _mouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (gameObject.name == "pos1")
            {
                gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-381, 1047, 0);
            }
            if (gameObject.name == "pos2")
            {
                gameObject.GetComponent<RectTransform>().localPosition = new Vector3(494, 1047, 0);
            }
            if (gameObject.name == "pos3")
            {
                gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-381, 361, 0);
            }
            if (gameObject.name == "pos4")
            {
                gameObject.GetComponent<RectTransform>().localPosition = new Vector3(494, 361, 0);
            }
        }
    }

    void _boardPosSetup()
    {
        if (_posY > 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                GameObject.Find("GameManager_obj").GetComponent<GameManager>()._money -= _cost;
                _cost = 0;
            }
            if (_posX < 50 && _posY > 785)
            {
                if (GameObject.Find("pos1") == null)
                {
                    gameObject.name = "pos1";
                }
            }
            if (_posX > 50 && _posY > 785)
            {
                if (GameObject.Find("pos2") == null)
                {
                    gameObject.name = "pos2";
                }
            }
            if (_posX < 50 && _posY < 785)
            {
                if (GameObject.Find("pos3") == null)
                {
                    gameObject.name = "pos3";
                }
            }
            if (_posX > 50 && _posY < 785)
            {
                if (GameObject.Find("pos4") == null)
                {
                    gameObject.name = "pos4";
                }
            }
        }
        else
        {
            gameObject.name = "Holding";
        }
    }
}
