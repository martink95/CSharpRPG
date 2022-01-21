using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items.Armors
{
    public class ArmorList
    {
        // LVL 3 Armor
        //Head
        Armor head1 = new Armor("Stronger Cloth head", "Head", "Cloth", 3, 6, 0, 0, 15);
        Armor head2 = new Armor("Stronger Leather head", "Head", "Leather", 3, 0, 1, 6, 20);
        Armor head3 = new Armor("Stronger Mail head", "Head", "Mail", 3, 0, 7, 0, 25);
        Armor head4 = new Armor("Stronger Plate head", "Head", "Plate", 3, 0, 9, 0, 30);
        //Body
        Armor Body1 = new Armor("Stronger Cloth Body", "Body", "Cloth", 3, 10, 0, 0, 20);
        Armor Body2 = new Armor("Stronger Leather Body", "Body", "Leather", 3, 0, 1, 10, 25);
        Armor Body3 = new Armor("Stronger Mail Body", "Body", "Mail", 3, 0, 10, 0, 30);
        Armor Body4 = new Armor("Stronger Plate Body", "Body", "Plate", 3, 0, 12, 0, 40);
        //Legs
        Armor Legs1 = new Armor("Stronger Cloth Legs", "Leg", "Cloth", 3, 8, 0, 0, 18);
        Armor Legs2 = new Armor("Stronger Leather Legs", "Leg", "Leather", 3, 0, 1, 8, 22);
        Armor Legs3 = new Armor("Stronger Mail Legs", "Leg", "Mail", 3, 0, 8, 0, 25);
        Armor Legs4 = new Armor("Stronger Plate Legs", "Leg", "Plate", 3, 0, 10, 0, 32);
        // LVL 6 Armor
        //Head
        Armor head5 = new Armor("Strongest Cloth head", "Head", "Cloth", 6, 15, 0, 0, 25);
        Armor head6 = new Armor("Strongest Leather head", "Head", "Leather", 6, 0, 1, 15, 30);
        Armor head7 = new Armor("Strongest Mail head", "Head", "Mail", 6, 0, 15, 0, 35);
        Armor head8 = new Armor("Strongest Plate head", "Head", "Plate", 6, 0, 15, 0, 40);
        //Body
        Armor Body5 = new Armor("Strongest Cloth Body", "Body", "Cloth", 6, 23, 0, 0, 35);
        Armor Body6 = new Armor("Strongest Leather Body", "Body", "Leather", 3, 0, 1, 23, 45);
        Armor Body7 = new Armor("Strongest Mail Body", "Body", "Mail", 6, 0, 23, 0, 50);
        Armor Body8 = new Armor("Strongest Plate Body", "Body", "Plate", 6, 0, 25, 0, 60);
        //Legs
        Armor Legs5 = new Armor("Strongest Cloth Legs", "Leg", "Cloth", 6, 14, 0, 0, 28);
        Armor Legs6 = new Armor("Strongest Leather Legs", "Leg", "Leather", 6, 0, 1, 15, 42);
        Armor Legs7 = new Armor("Strongest Mail Legs", "Leg", "Mail", 6, 0, 16, 0, 45);
        Armor Legs8 = new Armor("Strongest Plate Legs", "Leg", "Plate", 6, 0, 18, 0, 62);

        public Armor[] GetList()
        {
            Armor[] armorList =
            {
                head1,
                head2,
                head3,
                head4,
                head5,
                head6,
                head7,
                head8,
                Body1,
                Body2,
                Body3,
                Body4,
                Body5,
                Body6,
                Body7,
                Body8,
                Legs1,
                Legs2,
                Legs3,
                Legs4,
                Legs5,
                Legs6,
                Legs7,
                Legs8,
            };
            return armorList;
        }
    }
}
