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

	void LO_AddTexture ()
	{
		GameObject tex = NGUITools.AddChild (parentView);
		UITexture texture = tex.AddComponent<UITexture> ();
		texture.mainTexture = useTexure;
//		texture.color = Color.red;

		texture.type = UIBasicSprite.Type.Filled;
		texture.fillDirection = UIBasicSprite.FillDirection.Radial360;
		texture.fillAmount = 1.0f;

		texture.pivot = UIWidget.Pivot.TopLeft;
		texture.transform.localPosition = new Vector3 (0, 0, 0);
		texture.width = 200;
		texture.height = 200;

		texture.SetAnchor (parentView.transform);
//		texture.leftAnchor.target = parentView.transform;
		texture.leftAnchor.relative = 0f;
		texture.leftAnchor.absolute = 300;

//		texture.rightAnchor.target = parentView.transform;
		texture.rightAnchor.relative = 1;
		texture.rightAnchor.absolute = -300;


//		texture.bottomAnchor.target = parentView.transform;
		texture.bottomAnchor.relative = 0;
		texture.bottomAnchor.absolute = 100;

//		texture.topAnchor.target = parentView.transform;
		texture.topAnchor.relative = 1;
		texture.topAnchor.absolute = -100;



	}
}
