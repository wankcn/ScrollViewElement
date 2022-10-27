// Author: 文若
// CreateDate: 2022/10/14

using System;
using UnityEngine;

namespace GameNeon.Modules.UIModule
{
    public class RecycleView : MonoBehaviour
    {
        public RectTransform content;
        public Vector2 itemSize;
        public Vector2 interSpace;
        [Range(1, 20)] public int showLine;
        public int showViewH;
        private RecycleViewCore<Item, BagItem> sv;
        public string boxResPath;
        public GameObject sample;

        private void Start()
        {
            // 这一行是测试数据
            var data = new BagData();
            if (content == null) return;
            sv = new RecycleViewCore<Item, BagItem>(sample);
            sv.InitItemResName(boxResPath);
            sv.InitItemSizeAndCol(itemSize, interSpace, showLine);
            sv.InitContentSVH(content, showViewH);
            sv.InitInfos(data.GetData());
        }

        private void Update()
        {
            if (content)
                sv.CheckShowOrHide();
        }


        private void OnDestroy()
        {
            sv.ClearData();
        }
    }
}