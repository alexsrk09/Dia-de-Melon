using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
	private Rigidbody2D rb;
	private SpriteRenderer sprite;
	private Animator animatior;
	[SerializeField] private float velocity = 5f;
	[SerializeField] private bool controllable = true;
    //Chekear si el personaje se puede controlar. Por ejemplo que no se pueda mover si esta en dialogo

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animatior = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
        Vector2 direction = Vector2.zero;

		if (controllable)
		{
			direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
			if (direction != Vector2.zero)
			{
				rb.MovePosition(rb.position + direction * velocity * Time.fixedDeltaTime);
			}
			else
			{
				rb.MovePosition(rb.position);
			}
		}
		// animate move right
		animatior.SetBool("move_right", direction.x > 0);
		// animate move left
		if (direction.x < 0) {
			animatior.SetBool("move_right", true);
			sprite.flipX = true;
		} else {
			sprite.flipX = false;
		}
		animatior.SetBool("move_front", direction.y < 0);
		if (direction.y > 0) moveBack();
		// if the last direcrtion move_back, idle_back is true
		animatior.SetBool("idle_back", direction.y > 0 && direction.x == 0);
		// if there is no direction
		if (direction == Vector2.zero)
		{
			animatior.SetBool("move_right", false);
			animatior.SetBool("move_back", false);
		}
	}

	public void SetControllable(bool value)
	{
		controllable = value;
	}

	public bool GetControllable()
	{
		return controllable;
	}
	private void moveBack(){
		animatior.SetBool("move_back", true);
	}
}
