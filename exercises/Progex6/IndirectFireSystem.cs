using System;
using System.Collections.Generic;
using System.Text;

namespace Progex6
{
    class IndirectFireSystem : WeaponSystem
    {
        private string indirectCaliber;
        private string indirectType;
        private string indirectName;
        private int range;
        public override void Load()
        {
            Console.WriteLine($"Another round is loaded in the {indirectType}, charges set!");
        }

        public override void Fire()
        {
            Console.WriteLine($"{indirectName} receiving targeting data.....FIRE! Direct hit!");
        }

        public override void Clean()
        {
            Console.WriteLine("Better get the carbon scoring off of the tube or else our accuracy will be reduced!");
        }

        public void DisplayRange()
        {
            Console.WriteLine($"This {indirectName} can fire {range} meters");
        }

        public IndirectFireSystem() : base()
        {
            range = 0;
        }

        public IndirectFireSystem(string indirectCaliber, string indirectType, string indirectName, int range) : base(indirectCaliber, indirectType, indirectName)
        {
            this.indirectCaliber = indirectCaliber;
            this.indirectType = indirectType;
            this.indirectName = indirectName;
            this.range = range;
        }

    }
}