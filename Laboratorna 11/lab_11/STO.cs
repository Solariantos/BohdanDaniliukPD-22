namespace lab_11
{
    class STO
    {
        public void collapseClimbDone(Car car) => car.collapseClimbDone = true;
        public void painted(Car car) => car.painted = true;
        public void oilChangePerformed(Car car) => car.oilChangePerformed = true;
        public void fullTechnicalInspectionPassed(Car car) => car.fullTechnicalInspectionPassed = true;
        public void wheelReplacementPerformed(Car car) => car.wheelReplacementPerformed = true;
        public void bodyRepairPerformed(Car car) => car.bodyRepairPerformed = true;
    
    }
}