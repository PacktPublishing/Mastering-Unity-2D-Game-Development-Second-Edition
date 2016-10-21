using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour{
  // RigidBody component instance for the player
  private Rigidbody2D playerRigidBody2D;

 //Variable to track how much movement is needed from input
  private float movePlayerHorizontal;
  private float movePlayerVertical;
  private Vector2 movement;
 
  // Speed modifier for player movement
  public float speed = 4.0f;

  // Animator component for the player
  private Animator playerAnim;

  //Sprite renderer for the player
  private SpriteRenderer playerSpriteImage;

  //Initialize any component references
  void Awake(){
		playerRigidBody2D = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
		playerAnim=(Animator)GetComponent(typeof(Animator));
		playerSpriteImage=(SpriteRenderer)GetComponent(typeof(SpriteRenderer));
  }

  // Update is called once per frame
  void Update () {
		movePlayerHorizontal = Input.GetAxis("Horizontal");
		movePlayerVertical = Input.GetAxis("Vertical");
		movement=new Vector2(movePlayerHorizontal,movePlayerVertical);

		playerRigidBody2D.velocity=movement*speed;

		if(movePlayerVertical==0 && movePlayerHorizontal==0){
			playerAnim.SetBool("moving",false);
		}else{
			playerAnim.SetBool("moving",true);
		}

		if(movePlayerVertical!=0){
			playerAnim.SetBool("xMove",false);
			playerSpriteImage.flipX=false;

			if(movePlayerVertical>0){
				playerAnim.SetInteger("yMove",1);

			}else if(movePlayerVertical<0){
				playerAnim.SetInteger("yMove",-1);

			}
		}else {
			playerAnim.SetInteger("yMove",0);

			if(movePlayerHorizontal>0){
				playerAnim.SetBool("xMove",true);
				playerSpriteImage.flipX=false;
			
			}else if(movePlayerHorizontal<0){
				playerAnim.SetBool("xMove",true);
				playerSpriteImage.flipX=true;

			}else{
				playerAnim.SetBool("xMove",false);
			}
		}

  }

}
