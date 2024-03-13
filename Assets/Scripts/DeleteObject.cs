using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteObject : MonoBehaviour
{
    public Transform container;
    public void Remove(GameObject element)
    {
        float elementHeight = element.GetComponent<RectTransform>().rect.height;
        int index = element.transform.GetSiblingIndex();
        Destroy(element.gameObject);

        RectTransform containerRect = container.GetComponent<RectTransform>();
        containerRect.sizeDelta = new Vector2(containerRect.sizeDelta.x, containerRect.sizeDelta.y - elementHeight);

        for (int i = index + 1; i < container.childCount; i++)
        {
            container.GetChild(i).SetSiblingIndex(i - 1);
        }
    }
}
