using System;
using System.Collections.Generic;
using System.Text;

namespace Progex6
{
    class NonCommissionedOfficer : Personnel
    {
        private string nonCommissionedOfficerName;
        private string nonCommissionedOfficerRank;
        private string nonCommissionedOfficerPosition;
        private string nonCommissionedOfficerSkill;

        public void SmokeBreak()
        {
            Console.WriteLine($" {nonCommissionedOfficerRank} {nonCommissionedOfficerName} went out for a smoke break.");
        }

        public void GiveCounselingStatement()
        {
            Console.WriteLine("Don't ever do something that stupid again! Now sign here and go clean the barracks!");
        }

        public NonCommissionedOfficer() : base()
        {

        }

        public NonCommissionedOfficer(string nonCommissionedOfficerName, string nonCommissionedOfficerRank, string nonCommissionedOfficerPosition, string nonCommissionedOfficerSkill) : base(nonCommissionedOfficerName, nonCommissionedOfficerRank, nonCommissionedOfficerPosition, nonCommissionedOfficerSkill)
        {
            this.nonCommissionedOfficerName = nonCommissionedOfficerName;
            this.nonCommissionedOfficerRank = nonCommissionedOfficerRank;
            this.nonCommissionedOfficerPosition = nonCommissionedOfficerPosition;
            this.nonCommissionedOfficerSkill = nonCommissionedOfficerSkill;
        }
    }
}