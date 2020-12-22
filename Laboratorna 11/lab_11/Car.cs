using System;

namespace lab_11
{
    class Car
    {
        public bool collapseClimbDone { get; set; }
        public bool painted { get; set; }
        public bool oilChangePerformed { get; set; }
        public bool fullTechnicalInspectionPassed{ get; set; }
        public bool wheelReplacementPerformed { get; set; }
        public bool bodyRepairPerformed { get; set; }
     
    
        public void showInfo()
        {
            Console.WriteLine($"collapse-climb is done - {collapseClimbDone}");
            Console.WriteLine($"painted - {painted}");
            Console.WriteLine($"oil change is performed - {oilChangePerformed}");
            Console.WriteLine($"full technical inspection passed - {fullTechnicalInspectionPassed}");
            Console.WriteLine($"wheel replacement performed - {wheelReplacementPerformed}");
            Console.WriteLine($"body repair performed - {bodyRepairPerformed}");

        }
    }
   
}
