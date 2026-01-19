using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenSpriteRendererBehaviour : TweenAnimationBehaviour<SpriteRenderer>
    {
        [SerializeField] ColorTweenParameter color;

        public ReadOnlyTweenParameter<Color> Color => color;

        public override void OnTweenInitialize(SpriteRenderer playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
        }
    }
}
