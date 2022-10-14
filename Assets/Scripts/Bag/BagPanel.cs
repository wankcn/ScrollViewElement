using UnityEngine;

public class BagPanel : BasePanel
{
    public RectTransform content;
    public Vector2 itemSize;
    public Vector2 interSpace;
    [Range(1,20)]
    public int showLine;
    public int showViewH;
    private CustomSV<Item, BagItem> sv;

    private void Start()
    {
        if (content == null) return;
        sv = new CustomSV<Item, BagItem>();
        sv.InitItemResName("UI/BagItem");
        sv.InitItemSizeAndCol(itemSize, interSpace, showLine);
        sv.InitContentSVH(content, showViewH);
        sv.InitInfos(BagMgr.GetInstance().items);
    }

    private void Update()
    {
        if (content)
        {
            sv.InitItemSizeAndCol(itemSize, interSpace, showLine);
            sv.CheckShowOrHide();
        }

       
    }
}