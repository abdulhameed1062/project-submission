using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Image containerImage;
    public Sprite receivingSprite;
    public bool doAnim;
   
   

    public void OnDrop(PointerEventData data)
    {

        receivingSprite = GetDropSprite(data);

        if (containerImage.sprite == receivingSprite)
        {
            doAnim = true;
            Counter.m_agent.count++;
        }
        else
        {
            print("Not Matched");
        }
    }

    public void OnPointerEnter(PointerEventData data)
    {
       
        if (containerImage == null)
            return;
    }

    public void OnPointerExit(PointerEventData data)
    {
       
        if (containerImage == null)
            return;
    }

    private Sprite GetDropSprite(PointerEventData data)
    {
        var originalObj = data.pointerDrag;
       
        if (originalObj == null)
            return null;

        var dragMe = originalObj.GetComponent<DragMe>();
        if (dragMe == null)
            return null;

        var srcImage = originalObj.GetComponent<Image>();
        if (srcImage == null)
            return null;

        return srcImage.sprite;
    }

    void Update()
    {
        if (doAnim)
        {
            containerImage.fillAmount = containerImage.fillAmount - 0.5f * Time.deltaTime;
           
            if (containerImage.fillAmount == 0)
            {
                containerImage.enabled = false;

                Counter.m_agent.CheckCount();
                doAnim = false;

            }

        }


    }
}
