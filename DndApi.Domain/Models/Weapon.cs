namespace DndApi.Domain.Models
{
    using Core.Enums;
    using Core.Models;

    public class Weapon : Equipment<WeaponCategory>
    {
        public WeaponCategory WeaponCategory { get; set; }

        public WeaponRange WeaponRange { get; set; }

        public DamageType DamageType { get; set; }

        public Damage Damage { get; set; }

        public Damage SecondDamage { get; set; }

        public Range Range { get; set; }

        public Range ThrowRange { get; set; }
    }
}
