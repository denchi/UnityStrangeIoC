using strange.extensions.context.impl;
using UniRx;
using UnityEngine;

namespace strange.extensions.mediation.impl
{
    public class ExView : View
    {
        public ReactiveProperty<bool> Injected { get; private set; } = new ReactiveProperty<bool>();

        protected override ContextView FindContext(MonoBehaviour view)
        {
            return FindObjectOfType<ContextView>();
        }

        [PostConstruct]
        protected virtual void OnInjected()
        {
            Injected.SetValueAndForceNotify(true);
        }
    }
}