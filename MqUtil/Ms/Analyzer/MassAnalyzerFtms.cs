﻿namespace MqUtil.Ms.Analyzer{
	public class MassAnalyzerFtms : MsmsMassAnalyzer{
		public MassAnalyzerFtms(int index) : base(index) {}
		public override double MatchToleranceDefault => 20;
		public override double DeNovoToleranceDefault => 25;
		public override double DeisotopeToleranceDefault => 7;
		public override bool MatchToleranceInPpmDefault => true;
		public override bool DeNovoToleranceInPpmDefault => true;
		public override bool DeisotopeToleranceInPpmDefault => true;
		public override bool DeisotopeDefault => true;
		public override bool HigherChargesDefault => true;
		public override bool WaterDefault => true;
		public override bool AmmoniaDefault => true;
        public override bool WaterCrossDefault => false;
		public override bool AmmoniaCrossDefault => false;
		public override bool DependentLossesDefault => true;
		public override bool RecalibrationDefault => false;
		public override int TopxDefault => 12;
		public override double TopxIntervalDefault => 100;
		public override string Name => "FTMS";
		public override string Description => "MS/MS spectra that are measured in the Orbitrap mass analyzer or with FT-ICR.";
	}
}