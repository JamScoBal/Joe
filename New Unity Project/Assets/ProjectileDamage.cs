using UnityEngine;
using System.Collections;

public class ProjectileDamage : MonoBehaviour {
	private int Weak = 1;
	private int Strong = 2;
	private int Super = 3;


	void Start ()
	{
		Boom = GetComponent<EnemyDamage> ();
	}

	void OnCollisionEnter(Collision Hit)
	{
		if (Hit.transform.tag == "projectile") {
			switch (Boom.Type) {
			case EnemyDamage.Badguys.Enemy:
				Boom.Damage (Weak);
				break;
			case EnemyDamage.Badguys.Enemy2:
				Boom.Damage (Strong);
				break;
			case EnemyDamage.Badguys.Enemy3:
				Boom.Damage (Super);
				break;
			default:
				Boom.Damage (0);
				break;
			}
		}
	}
	public EnemyDamage Boom;


}
