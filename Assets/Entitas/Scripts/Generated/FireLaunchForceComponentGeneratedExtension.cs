//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public FireLaunchForceComponent fireLaunchForce { get { return (FireLaunchForceComponent)GetComponent(ComponentIds.FireLaunchForce); } }

        public bool hasFireLaunchForce { get { return HasComponent(ComponentIds.FireLaunchForce); } }

        public Entity AddFireLaunchForce(float newValue, float newMin, float newMax) {
            var component = CreateComponent<FireLaunchForceComponent>(ComponentIds.FireLaunchForce);
            component.value = newValue;
            component.min = newMin;
            component.max = newMax;
            return AddComponent(ComponentIds.FireLaunchForce, component);
        }

        public Entity ReplaceFireLaunchForce(float newValue, float newMin, float newMax) {
            var component = CreateComponent<FireLaunchForceComponent>(ComponentIds.FireLaunchForce);
            component.value = newValue;
            component.min = newMin;
            component.max = newMax;
            ReplaceComponent(ComponentIds.FireLaunchForce, component);
            return this;
        }

        public Entity RemoveFireLaunchForce() {
            return RemoveComponent(ComponentIds.FireLaunchForce);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherFireLaunchForce;

        public static IMatcher FireLaunchForce {
            get {
                if (_matcherFireLaunchForce == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.FireLaunchForce);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherFireLaunchForce = matcher;
                }

                return _matcherFireLaunchForce;
            }
        }
    }
}
