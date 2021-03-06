using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpriteSelector : MonoBehaviour {

	public Sprite sp;
	public bool up, down, left, right;
	public int type;
	public Color normalColor, enterColor;
	Color mainColor;
	SpriteRenderer rend;
	void Start () {
		rend = GetComponent<SpriteRenderer>();
		mainColor = normalColor;
		PickSprite();
		PickColor();
	}
	void PickSprite(){ 
		if (up) {
			if (down) {
				if (right) {
					if (left) {
						rend.sprite = sp;
					}
				}
			}
		}
		return;

		if (down) {
			if (right) {
				if (left) {
					rend.sprite = sp;
				}
			}
		}
	}

	void PickColor(){ 
		if (type == 0){
			mainColor = normalColor;
		}else if (type == 1){
			mainColor = enterColor;
		}
		rend.color = mainColor;
	}
}