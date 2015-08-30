using UnityEngine;
using System.Collections;

public class CreateTexture : MonoBehaviour
{

	// Use this for initialization
	public GameObject parentView;
	public Texture useTexure;
	void Start ()
	{
		LO_AddTexture ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	/**
	 *创建UITexture
	 */
	void LO_AddTexture ()
	{
		//创建一个空得游戏物体
		GameObject tex = NGUITools.AddChild (parentView);
		//增加一个UITexture组件
		UITexture texture = tex.AddComponent<UITexture> ();
		//增加Texture
		texture.mainTexture = useTexure;
//		texture.color = Color.red;

		//设置填充模式和填充值
		texture.type = UIBasicSprite.Type.Filled;
		texture.fillDirection = UIBasicSprite.FillDirection.Radial360;
		texture.fillAmount = 1.0f;

		//设置中心点
		texture.pivot = UIWidget.Pivot.TopLeft;
		//设置位置
		texture.transform.localPosition = new Vector3 (0, 0, 0);
		//设置尺寸
		texture.width = 200;
		texture.height = 200;

		//设置锚点
		texture.SetAnchor (parentView.transform);
		//设置左边锚点
		//texture.leftAnchor.target = parentView.transform;
		texture.leftAnchor.relative = 0f;
		texture.leftAnchor.absolute = 300;

		//设置右边锚点
		//texture.rightAnchor.target = parentView.transform;
		texture.rightAnchor.relative = 1;
		texture.rightAnchor.absolute = -300;

		//设置底部锚点
		//texture.bottomAnchor.target = parentView.transform;
		texture.bottomAnchor.relative = 0;
		texture.bottomAnchor.absolute = 100;

		//设置顶部
		//texture.topAnchor.target = parentView.transform;
		texture.topAnchor.relative = 1;
		texture.topAnchor.absolute = -100;
	}
}
