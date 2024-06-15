using System;
using UnityEngine;
using R3;

namespace Assets.MyAssets.InGame.Slimes.Specials
{
    /// <summary>
    /// 炎属性のスペシャルのクラス
    /// </summary>
    public class SpecialFire : BaseSpecial
    {
        private SpecialTypes _specialTypes = SpecialTypes.Fire;
        [SerializeField]
        private Rigidbody2D _rigidBody2D;

        private float _forcePower = 2.5f;
        
        public override void OnInitialize(float xDirection)
        {
            _rigidBody2D.AddForce(new Vector2(xDirection,0F) * _forcePower,ForceMode2D.Impulse);
            
            Observable.Timer(TimeSpan.FromSeconds(1))
                .Subscribe(_ => Destroy(this.gameObject)).AddTo(this);
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            /*
            var ememyDamegeable = collision.gameObject.GetComponent<IEnemyDamegeable>();
            if (ememyDamegeable)
            {
                Debug.Log(ememyDamegeable);
            }*/
        }
    }
    
}
